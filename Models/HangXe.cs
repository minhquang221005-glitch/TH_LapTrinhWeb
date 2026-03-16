namespace Buoi1.Models
{
    public class HangXe
    {
        public int Id { get; set; }
        public string TenHang { get; set; } = string.Empty;

        // Navigation: one HangXe has many XeMay
        public ICollection<XeMay> XeMays { get; set; } = new List<XeMay>();
    }
}