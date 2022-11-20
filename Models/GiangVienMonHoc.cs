namespace SchoolController.Models
{
    public partial class GiangVienMonHoc
    {
        public string MaGiangVien { get; set; } = null!;
        public string MaMonHoc { get; set; } = null!;
        public int? DanhGia { get; set; }
        public virtual GiangVien MaGiangVienNavigation { get; set; } = null!;
        public virtual MonHoc MaMonHocNavigation { get; set; } = null!;
    }
}
