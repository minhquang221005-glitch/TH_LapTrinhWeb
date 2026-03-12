using System.ComponentModel.DataAnnotations; // Dùng cái này để bắt lỗi (Validate)

namespace Buoi1.Models
{
    public class DangKyViewModel
    {
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Độ dài từ 3 đến 20 ký tự")]
        public string TenDangNhap { get; set; } = string.Empty; // Sửa chỗ này

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty; // Sửa chỗ này

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; } = string.Empty; // Sửa chỗ này

        [Display(Name = "Nhập lại mật khẩu")]
        [Compare("MatKhau", ErrorMessage = "Mật khẩu không khớp")]
        [DataType(DataType.Password)]
        public string XacNhanMatKhau { get; set; } = string.Empty; // Sửa chỗ này
    }
}