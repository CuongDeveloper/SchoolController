namespace SchoolController.Models
{
    public partial class PhuHuynh
    {
        public PhuHuynh()
        {
            SinhViens = new HashSet<SinhVien>();
        }
        public string MaPhuHuynh { get; set; } = null!;
        public string TenPhuHuynh { get; set; } = null!;
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Hinh { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public virtual TaiKhoan TenTaiKhoanNavigation { get; set; } = null!;
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
