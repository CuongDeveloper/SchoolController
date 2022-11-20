namespace SchoolController.Models
{
    public partial class DiemSo
    {
        public string MaSinhVien { get; set; } = null!;
        public string MaMonHoc { get; set; } = null!;
        public string MaGiangVien { get; set; } = null!;
        public string MaLop { get; set; } = null!;
        public virtual GiangVien MaGiangVienNavigation { get; set; } = null!;
        public virtual Lop MaLopNavigation { get; set; } = null!;
        public virtual MonHoc MaMonHocNavigation { get; set; } = null!;
        public virtual SinhVien MaSinhVienNavigation { get; set; } = null!;
    }
}
