namespace Buoi1.Models
{
    public class SanPham
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public int Gia { get; set; }

        // Thêm dòng này vào:
        public string? HinhAnh { get; set; }

    }
}
