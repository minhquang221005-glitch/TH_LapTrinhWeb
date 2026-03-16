using Buoi1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text.Json;

namespace Buoi1.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        private const string CartSessionKey = "Cart";

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        private List<CartItem> GetCart()
        {
            var cartJson = HttpContext.Session.GetString(CartSessionKey);
            if (string.IsNullOrEmpty(cartJson))
                return new List<CartItem>();
            try
            {
                return JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();
            }
            catch
            {
                return new List<CartItem>();
            }
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetString(CartSessionKey, JsonSerializer.Serialize(cart));
        }

        public IActionResult Index()
        {
            var cart = GetCart();
            ViewBag.TotalItems = cart.Count;
            ViewBag.TotalPrice = cart.Sum(x => x.ThanhTien);
            return View(cart);
        }

        [HttpPost]
        public IActionResult ThemVaoGio(int id, int soLuong = 1)
        {
            var sanPham = _context.SanPhams.Find(id);
            if (sanPham == null)
            {
                TempData["Error"] = "San pham khong ton tai!";
                return RedirectToAction("Index", "Home");
            }

            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.SanPhamId == id);

            if (item != null)
            {
                item.SoLuong += soLuong;
            }
            else
            {
                cart.Add(new CartItem
                {
                    SanPhamId = id,
                    TenSanPham = sanPham.TenSanPham,
                    Gia = sanPham.Gia,
                    SoLuong = soLuong,
                    HinhAnh = sanPham.HinhAnh ?? ""
                });
            }

            SaveCart(cart);
            TempData["Success"] = $"Da them '{sanPham.TenSanPham}' vao gio hang!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CapNhatSoLuong(int id, int soLuong)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.SanPhamId == id);
            if (item != null)
            {
                item.SoLuong = soLuong < 1 ? 1 : soLuong;
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Xoa(int id)
        {
            var cart = GetCart();
            cart.RemoveAll(x => x.SanPhamId == id);
            SaveCart(cart);
            return RedirectToAction("Index");
        }

        public IActionResult XoaToan()
        {
            HttpContext.Session.Remove(CartSessionKey);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ThanhToan()
        {
            var cart = GetCart();
            if (!cart.Any())
            {
                TempData["Error"] = "Gio hang trong!";
                return RedirectToAction("Index");
            }

            var userJson = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(userJson))
            {
                TempData["Error"] = "Vui long dang nhap de dat hang.";
                return RedirectToAction("DangNhap", "TaiKhoan");
            }

            try
            {
                var userData = JsonSerializer.Deserialize<Dictionary<string, object>>(userJson ?? "{}");
                var userId = int.Parse(userData?["Id"]?.ToString() ?? "0");

                var donHang = new DonHang
                {
                    UserId = userId,
                    NgayDat = DateTime.Now,
                    TrangThai = "ChoDuyet",
                    TongTien = cart.Sum(x => x.Gia * x.SoLuong)
                };

                _context.DonHangs.Add(donHang);
                _context.SaveChanges();

                foreach (var it in cart)
                {
                    var ct = new ChiTietDonHang
                    {
                        DonHangId = donHang.Id,
                        SanPhamId = it.SanPhamId,
                        SoLuong = it.SoLuong,
                        GiaTaiThoiDiemDat = it.Gia
                    };
                    _context.ChiTietDonHangs.Add(ct);
                }

                _context.SaveChanges();
                HttpContext.Session.Remove(CartSessionKey);
                TempData["Success"] = "Dat hang thanh cong! Ma don: " + donHang.Id;
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                TempData["Error"] = "Co loi khi luu don hang. Vui long thu lai.";
                return RedirectToAction("Index");
            }
        }
    }
}
