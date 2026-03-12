using Microsoft.AspNetCore.Mvc;
using Buoi1.Models;
using System.Text.Json;

namespace Buoi1.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly AppDbContext _context;

        public TaiKhoanController(AppDbContext context)
        {
            _context = context;
        }

        // Lịch sử đơn hàng của user
        public IActionResult LichSuDonHang()
        {
            var user = GetCurrentUser();
            if (user == null)
            {
                TempData["Error"] = "Vui lòng đăng nhập để xem lịch sử đơn hàng.";
                return RedirectToAction("DangNhap");
            }

            var donHangs = _context.DonHangs
                .Where(d => d.UserId == user.Id)
                .OrderByDescending(d => d.NgayDat)
                .ToList();

            return View(donHangs);
        }

        public IActionResult ChiTiet(int id)
        {
            var user = GetCurrentUser();
            if (user == null)
            {
                TempData["Error"] = "Vui lòng đăng nhập.";
                return RedirectToAction("DangNhap");
            }

            var dh = _context.DonHangs.FirstOrDefault(d => d.Id == id && d.UserId == user.Id);
            if (dh == null) return NotFound();

            var cts = _context.ChiTietDonHangs.Where(c => c.DonHangId == dh.Id).ToList();
            ViewBag.ChiTiets = cts;
            return View(dh);
        }

        // ============ ĐĂNG KÝ ============
        [HttpGet]
        public IActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DangKy(DangKyViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem username đã tồn tại chưa
                if (_context.NguoiDungs.Any(x => x.TenDangNhap == model.TenDangNhap))
                {
                    ModelState.AddModelError("TenDangNhap", "Tên đăng nhập đã tồn tại!");
                    return View(model);
                }

                // Kiểm tra xem email đã tồn tại chưa
                if (_context.NguoiDungs.Any(x => x.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Email đã được đăng ký!");
                    return View(model);
                }

                // Tạo user mới (role mặc định = "User")
                var nguoiDung = new NguoiDung
                {
                    TenDangNhap = model.TenDangNhap,
                    Email = model.Email,
                    MatKhau = model.MatKhau, // Trong thực tế phải mã hóa bằng bcrypt
                    VaiTro = "User",
                    NgayTao = DateTime.Now,
                    DaKichHoat = true
                };

                _context.NguoiDungs.Add(nguoiDung);
                _context.SaveChanges();

                TempData["Success"] = "Đăng ký thành công! Vui lòng đăng nhập.";
                return RedirectToAction("DangNhap");
            }

            return View(model);
        }

        // ============ ĐĂNG NHẬP ============
        [HttpGet]
        public IActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DangNhap(string TenDangNhap, string MatKhau)
        {
            if (string.IsNullOrEmpty(TenDangNhap) || string.IsNullOrEmpty(MatKhau))
            {
                ModelState.AddModelError("", "Vui lòng nhập tên đăng nhập và mật khẩu!");
                return View();
            }

            // Tìm user trong DB
            var nguoiDung = _context.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == TenDangNhap);

            if (nguoiDung == null || nguoiDung.MatKhau != MatKhau)
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng!");
                return View();
            }

            if (!nguoiDung.DaKichHoat)
            {
                ModelState.AddModelError("", "Tài khoản chưa được kích hoạt!");
                return View();
            }

            // Lưu thông tin vào Session
            var userData = new
            {
                Id = nguoiDung.Id,
                TenDangNhap = nguoiDung.TenDangNhap,
                Email = nguoiDung.Email,
                VaiTro = nguoiDung.VaiTro
            };

            HttpContext.Session.SetString("User", JsonSerializer.Serialize(userData));
            TempData["Success"] = $"Chào mừng {nguoiDung.TenDangNhap}!";

            return RedirectToAction("Index", "Home");
        }

        // ============ ĐĂNG XUẤT ============
        public IActionResult DangXuat()
        {
            HttpContext.Session.Remove("User");
            TempData["Success"] = "Bạn đã đăng xuất!";
            return RedirectToAction("Index", "Home");
        }

        // ============ HELPER: Lấy thông tin user hiện tại ============
        public NguoiDung? GetCurrentUser()
        {
            var userJson = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(userJson))
                return null;

            try
            {
                var userData = JsonSerializer.Deserialize<Dictionary<string, object>>(userJson);
                return new NguoiDung
                {
                    Id = int.Parse(userData["Id"].ToString() ?? "0"),
                    TenDangNhap = userData["TenDangNhap"].ToString() ?? "",
                    Email = userData["Email"].ToString() ?? "",
                    VaiTro = userData["VaiTro"].ToString() ?? "User"
                };
            }
            catch
            {
                return null;
            }
        }
    }
}
