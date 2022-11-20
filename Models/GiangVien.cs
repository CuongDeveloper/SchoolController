namespace SchoolController.Models
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            DiemSos = new HashSet<DiemSo>();
            GiangVienMonHocs = new HashSet<GiangVienMonHoc>();
        }
        public string MaGiangVien { get; set; } = null!;
        public string TenGiangVien { get; set; } = null!;
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Hinh { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public virtual TaiKhoan TenTaiKhoanNavigation { get; set; } = null!;
        public virtual ICollection<DiemSo> DiemSos { get; set; }
        public virtual ICollection<GiangVienMonHoc> GiangVienMonHocs { get; set; }
    }
}
