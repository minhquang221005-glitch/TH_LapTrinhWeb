namespace Buoi1.Models
{
    public class ChiTietDonHang
    {
        public int Id { get; set; }
        public int DonHangId { get; set; }
        public int SanPhamId { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTaiThoiDiemDat { get; set; }

        // Navigation
        public DonHang? DonHang { get; set; }
        public SanPham? SanPham { get; set; }
    }
}