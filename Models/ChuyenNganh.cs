namespace SchoolController.Models
{
    public partial class ChuyenNganh
    {
        public ChuyenNganh()
        {
            SinhViens = new HashSet<SinhVien>();
            ChuyenNganhMonHocs = new HashSet<ChuyenNganhMonHoc>();
        }
        public string MaChuyenNganh { get; set; } = null!;
        public string TenChuyenNganh { get; set; } = null!;
        public virtual ICollection<ChuyenNganhMonHoc> ChuyenNganhMonHocs { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
