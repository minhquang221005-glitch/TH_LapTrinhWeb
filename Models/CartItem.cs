namespace Buoi1.Models
{
    public class CartItem
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }

        public int ThanhTien => Gia * SoLuong;
    }
}
