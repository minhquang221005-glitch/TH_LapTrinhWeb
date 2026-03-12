using System.ComponentModel.DataAnnotations.Schema;

namespace Buoi1.Models
{
    public class DonHang
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime NgayDat { get; set; } = DateTime.Now;
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; } = "ChoDuyet"; // "ChoDuyet/DangGiao/HoanThanh/HuyDon"

        // Navigation
        [NotMapped]
        public NguoiDung? User { get; set; }
        public List<ChiTietDonHang>? ChiTiets { get; set; }
    }
}