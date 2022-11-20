namespace SchoolController.Models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            DiemSos = new HashSet<DiemSo>();
        }
        public string MaSinhVien { get; set; } = null!;
        public string TenSinhVien { get; set; } = null!;
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Hinh { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public string MaPhuHuynh { get; set; } = null!;
        public string MaChuyenNganh { get; set; } = null!;
        public virtual ChuyenNganh MaChuyenNganhNavigation { get; set; } = null!;
        public virtual PhuHuynh MaPhuHuynhNavigation { get; set; } = null!;
        public virtual TaiKhoan TenTaiKhoanNavigation { get; set; } = null!;
        public virtual ICollection<DiemSo> DiemSos { get; set; }
    }
}
