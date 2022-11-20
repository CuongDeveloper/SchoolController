namespace SchoolController.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            DiemSos = new HashSet<DiemSo>();
            GiangVienMonHocs = new HashSet<GiangVienMonHoc>();
            ChuyenNganhMonHocs = new HashSet<ChuyenNganhMonHoc>();
        }
        public string MaMonHoc { get; set; } = null!;
        public string TenMonHoc { get; set; } = null!;
        public int SoTinChi { get; set; }
        public virtual ICollection<DiemSo> DiemSos { get; set; }
        public virtual ICollection<GiangVienMonHoc> GiangVienMonHocs { get; set; }
        public virtual ICollection<ChuyenNganhMonHoc> ChuyenNganhMonHocs { get; set; }
    }
}
