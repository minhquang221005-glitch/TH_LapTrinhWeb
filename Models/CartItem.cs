namespace Buoi1.Models
{
    public class CartItem
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; } = string.Empty;

        // Sửa từ int sang decimal để khớp với GiaBan trong database
        public decimal Gia { get; set; }

        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }

        // Thành tiền cũng phải là decimal để không bị lỗi tính toán
        public decimal ThanhTien => Gia * SoLuong;
    }
}