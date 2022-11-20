namespace SchoolController.Models
{
    public partial class CanBoDaoTao
    {
        public string MaCanBoDaoTao { get; set; } = null!;
        public string TenCanBoDaoTao { get; set; } = null!;
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Hinh { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public virtual TaiKhoan TenTaiKhoanNavigation { get; set; } = null!;
    }
}
