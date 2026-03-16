namespace Buoi1.Models
{
    public class XeMay
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public decimal Gia { get; set; }
        public int SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public int MaHangXe { get; set; }
        public virtual HangXe? HangXe { get; set; }
        public int PhanKhoi { get; set; }
        public string? MauSac { get; set; }
        public int NamSanXuat { get; set; }
    }
}