using Microsoft.AspNetCore.Mvc;
using Buoi1.Models;
using Microsoft.EntityFrameworkCore;

namespace Buoi1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sanPhams = _context.SanPhams
                .Include(x => x.HangXe)
                .OrderByDescending(x => x.Id)
                .Take(20)
                .ToList();
            return View(sanPhams);
        }

        public IActionResult DanhMuc(string ten)
        {
            ViewBag.TenDanhMuc = string.IsNullOrEmpty(ten) ? "San pham" : ten;
            var query = _context.SanPhams.Include(x => x.HangXe).AsQueryable();
            if (!string.IsNullOrEmpty(ten))
            {
                query = query.Where(x => x.TenSanPham.Contains(ten));
            }
            var sanPhams = query.OrderByDescending(x => x.Id).ToList();
            return View(sanPhams);
        }

        public IActionResult ChiTiet(int id)
        {
            var sanPham = _context.SanPhams
                .Include(x => x.HangXe)
                .FirstOrDefault(x => x.Id == id);
            if (sanPham == null)
            {
                return RedirectToAction("Index");
            }
            return View(sanPham);
        }
    }
}