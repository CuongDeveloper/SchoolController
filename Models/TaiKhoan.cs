namespace SchoolController.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            CanBoDaoTaos = new HashSet<CanBoDaoTao>();
            GiangViens = new HashSet<GiangVien>();
            PhuHuynhs = new HashSet<PhuHuynh>();
            SinhViens = new HashSet<SinhVien>();
        }
        public string TenTaiKhoan { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public virtual ICollection<CanBoDaoTao> CanBoDaoTaos { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<PhuHuynh> PhuHuynhs { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
