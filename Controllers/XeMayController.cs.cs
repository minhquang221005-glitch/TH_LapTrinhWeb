using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Buoi1.Models;

namespace Buoi1.Controllers
{
    public class XeMayController : Controller
    {
        private readonly AppDbContext _context;

        public XeMayController(AppDbContext context)
        {
            _context = context;
        }

        // Hiện danh sách xe máy
        public async Task<IActionResult> Index()
        {
            // Nhớ check lại tên DbSet trong AppDbContext của ông (là SanPhams hay XeMays)
            var listXe = await _context.SanPhams.Include(x => x.HangXe).ToListAsync();
            return View(listXe);
        }
    }
}