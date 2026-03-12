namespace Buoi1.Models
{
    public class NguoiDung
    {
        public int Id { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty; // Mã hóa trong thực tế
        
        // Role: "Admin" hoặc "User"
        public string VaiTro { get; set; } = "User";
        
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public bool DaKichHoat { get; set; } = true;
    }
}
