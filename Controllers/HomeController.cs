using Microsoft.AspNetCore.Mvc;
using Buoi1.Models; // Bắt buộc phải có để gọi AppDbContext và SanPham
using System.Linq;  // Bắt buộc để dùng OrderByDescending, Take, ToList...

namespace Buoi1.Controllers
{
    public class HomeController : Controller
    {
        // 1. Khai báo chìa khóa mở kho DB
        private readonly AppDbContext _context;

        // 2. Kỹ thuật tiêm phụ thuộc (Dependency Injection) - Bắt buộc để ASP.NET nhét DB vào
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult DanhMuc(string ten)
        {
            // Nếu cái 'ten' bị trống thì cho nó cái tên mặc định
            ViewBag.TenDanhMuc = string.IsNullOrEmpty(ten) ? "Sản phẩm" : ten;

            // Lọc sản phẩm theo chuỗi 'ten' (tìm kiếm theo tên sản phẩm)
            var query = _context.SanPhams.AsQueryable();
            if (!string.IsNullOrEmpty(ten))
            {
                // Ưu tiên các sản phẩm có tên bắt đầu với từ khóa, nếu không có thì tìm contains
                query = query.Where(x => x.TenSanPham.StartsWith(ten) || x.TenSanPham.Contains(ten));
            }

            var sanPhams = query.OrderByDescending(x => x.Id).ToList();
            return View(sanPhams);
        }

        // 3. ACTION INDEX: Lôi hàng thật từ SQL ra ném cho giao diện
        public IActionResult Index()
        {
            // Sắp xếp ID giảm dần (để hàng mới thêm hiện lên đầu), bốc ra 20 thằng
            var sanPhams = _context.SanPhams.OrderByDescending(x => x.Id).Take(20).ToList();

            // Quăng đống hàng thật này ra ngoài View
            return View(sanPhams);
        }

        // 4. ACTION CHITIET: Móc đúng 1 con hàng ra xem
        public IActionResult ChiTiet(int id)
        {
            // Lấy đúng thằng có ID truyền vào
            var sanPham = _context.SanPhams.Find(id);

            // Tìm đéo thấy thì đá nó về trang chủ
            if (sanPham == null)
            {
                return RedirectToAction("Index");
            }

            return View(sanPham);
        }
    }
}