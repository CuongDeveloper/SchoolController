namespace SchoolController.Models
{
    public partial class ChuyenNganhMonHoc
    {
        public string MaChuyenNganh { get; set; } = null!;
        public string MaMonHoc { get; set; } = null!;
        public virtual ChuyenNganh MaChuyenNganhNavigation { get; set; } = null!;
        public virtual MonHoc MaMonHocNavigation { get; set; } = null!;
    }
}
