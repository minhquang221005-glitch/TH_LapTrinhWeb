using Microsoft.AspNetCore.Mvc;
using Buoi1.Models;
using System.Linq;
using System.Text.Json;

namespace Buoi1.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly AppDbContext _context;

        public SanPhamController(AppDbContext context)
        {
            _context = context;
        }

        // Helper: Kiểm tra xem user có phải Admin không
        private bool IsAdmin()
        {
            var userJson = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(userJson))
                return false;

            try
            {
                var userData = JsonSerializer.Deserialize<Dictionary<string, object>>(userJson);
                var vaiTro = userData?["VaiTro"]?.ToString() ?? "";
                return vaiTro == "Admin";
            }
            catch
            {
                return false;
            }
        }

        // Helper: Lấy User ID từ session
        private int? GetUserId()
        {
            var userJson = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(userJson))
                return null;

            try
            {
                var userData = JsonSerializer.Deserialize<Dictionary<string, object>>(userJson);
                return int.Parse(userData?["Id"]?.ToString() ?? "0");
            }
            catch
            {
                return null;
            }
        }

        // --- ĐỌC (READ): Lấy đồ từ SQL ra ---
        public IActionResult Index()
        {
            // Kiểm tra xem có phải admin không
            if (!IsAdmin())
            {
                TempData["Error"] = "Chỉ Admin mới có quyền truy cập!";
                return RedirectToAction("Index", "Home");
            }

            var danhSach = _context.SanPhams.ToList();
            return View(danhSach);
        }

        // --- THÊM (CREATE) ---
        [HttpGet]
        public IActionResult Them()
        {
            if (!IsAdmin())
            {
                TempData["Error"] = "Chỉ Admin mới có quyền thêm sản phẩm!";
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Them(XeMay spMoi)
        {
            if (!IsAdmin())
            {
                TempData["Error"] = "Chỉ Admin mới có quyền!";
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.SanPhams.Add(spMoi);
                _context.SaveChanges();
                TempData["Success"] = "Thêm sản phẩm thành công!";
                return RedirectToAction("Index");
            }
            return View(spMoi);
        }

        // --- SỬA (UPDATE) ---
        [HttpGet]
        public IActionResult Sua(int id)
        {
            if (!IsAdmin())
            {
                TempData["Error"] = "Chỉ Admin mới có quyền sửa!";
                return RedirectToAction("Index", "Home");
            }

            var spCanSua = _context.SanPhams.Find(id);
            if (spCanSua == null)
                return RedirectToAction("Index");
            return View(spCanSua);
        }

        [HttpPost]
        public IActionResult Sua(XeMay spSua)
        {
            if (!IsAdmin())
            {
                TempData["Error"] = "Chỉ Admin mới có quyền!";
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.SanPhams.Update(spSua);
                _context.SaveChanges();
                TempData["Success"] = "Cập nhật sản phẩm thành công!";
                return RedirectToAction("Index");
            }
            return View(spSua);
        }

        // --- XÓA (DELETE) ---
        public IActionResult Xoa(int id)
        {
            if (!IsAdmin())
            {
                TempData["Error"] = "Chỉ Admin mới có quyền xóa!";
                return RedirectToAction("Index", "Home");
            }

            var spCanXoa = _context.SanPhams.Find(id);
            if (spCanXoa != null)
            {
                _context.SanPhams.Remove(spCanXoa);
                _context.SaveChanges();
                TempData["Success"] = "Xóa sản phẩm thành công!";
            }
            return RedirectToAction("Index");
        }
    }
}
