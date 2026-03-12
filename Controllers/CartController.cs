using Microsoft.AspNetCore.Mvc;
using Buoi1.Models;
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

        // Lấy giỏ hàng từ session
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

        // Lưu giỏ hàng vào session
        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetString(CartSessionKey, JsonSerializer.Serialize(cart));
        }

        // Hiển thị giỏ hàng
        public IActionResult Index()
        {
            var cart = GetCart();
            ViewBag.TotalItems = cart.Count;
            ViewBag.TotalPrice = cart.Sum(x => x.ThanhTien);
            return View(cart);
        }

        // Thêm sản phẩm vào giỏ
        [HttpPost]
        public IActionResult ThemVaoGio(int id, int soLuong = 1)
        {
            var sanPham = _context.SanPhams.Find(id);
            if (sanPham == null)
            {
                TempData["Error"] = "Sản phẩm không tồn tại!";
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
                    HinhAnh = sanPham.HinhAnh
                });
            }

            SaveCart(cart);
            TempData["Success"] = $"Đã thêm '{sanPham.TenSanPham}' vào giỏ hàng!";
            return RedirectToAction("Index");
        }

        // Cập nhật số lượng
        [HttpPost]
        public IActionResult CapNhatSoLuong(int id, int soLuong)
        {
            if (soLuong < 1)
                soLuong = 1;

            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.SanPhamId == id);

            if (item != null)
            {
                item.SoLuong = soLuong;
            }

            SaveCart(cart);
            return RedirectToAction("Index");
        }

        // Xóa sản phẩm khỏi giỏ
        public IActionResult Xoa(int id)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.SanPhamId == id);

            if (item != null)
            {
                cart.Remove(item);
                SaveCart(cart);
                TempData["Success"] = $"Đã xóa '{item.TenSanPham}' khỏi giỏ hàng!";
            }

            return RedirectToAction("Index");
        }

        // Xóa toàn bộ giỏ hàng
        public IActionResult XoaToan()
        {
            HttpContext.Session.Remove(CartSessionKey);
            TempData["Success"] = "Đã xóa toàn bộ giỏ hàng!";
            return RedirectToAction("Index");
        }

        // Thanh toán
        public IActionResult ThanhToan()
        {
            var cart = GetCart();
            if (!cart.Any())
            {
                TempData["Error"] = "Giỏ hàng trống!";
                return RedirectToAction("Index");
            }

            // Kiểm tra user đang đăng nhập
            var userJson = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(userJson))
            {
                TempData["Error"] = "Vui lòng đăng nhập để đặt hàng.";
                return RedirectToAction("DangNhap", "TaiKhoan");
            }

            try
            {
                var userData = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(userJson);
                var userId = int.Parse(userData?["Id"].ToString() ?? "0");

                // Tạo đơn hàng
                var donHang = new DonHang
                {
                    UserId = userId,
                    NgayDat = DateTime.Now,
                    TrangThai = "ChoDuyet",
                    TongTien = cart.Sum(x => (decimal)x.Gia * x.SoLuong)
                };

                _context.DonHangs.Add(donHang);
                _context.SaveChanges(); // Save để có DonHang.Id

                // Thêm chi tiết
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
                TempData["Success"] = "Đặt hàng thành công! Mã đơn: " + donHang.Id;
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                TempData["Error"] = "Có lỗi khi lưu đơn hàng. Vui lòng thử lại.";
                return RedirectToAction("Index");
            }
        }
    }
}
