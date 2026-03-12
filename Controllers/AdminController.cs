using Microsoft.AspNetCore.Mvc;
using Buoi1.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace Buoi1.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        private bool IsAdmin()
        {
            var userJson = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(userJson)) return false;
            try
            {
                var userData = JsonSerializer.Deserialize<Dictionary<string, object>>(userJson);
                return (userData?["VaiTro"]?.ToString() ?? "") == "Admin";
            }
            catch { return false; }
        }

        public IActionResult Dashboard()
        {
            if (!IsAdmin())
                return Forbid();

            var totalRevenue = _context.DonHangs.Sum(d => (decimal?)d.TongTien) ?? 0m;
            var totalOrders = _context.DonHangs.Count();
            var totalProducts = _context.SanPhams.Count();
            var recentOrders = _context.DonHangs
                .OrderByDescending(d => d.NgayDat)
                .Take(10)
                .ToList();

            ViewBag.TotalRevenue = totalRevenue;
            ViewBag.TotalOrders = totalOrders;
            ViewBag.TotalProducts = totalProducts;
            return View(recentOrders);
        }
    }
}