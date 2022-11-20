using Microsoft.EntityFrameworkCore;

namespace SchoolController.Models
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.Entity<SinhVien>().HasOne<TaiKhoan>(s => s.TenTaiKhoanNavigation).WithMany(g => g.SinhViens).HasForeignKey(s => s.TenTaiKhoan).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<SinhVien>().HasOne<PhuHuynh>(s => s.MaPhuHuynhNavigation).WithMany(g => g.SinhViens).HasForeignKey(s => s.MaPhuHuynh).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<SinhVien>().HasOne<ChuyenNganh>(s => s.MaChuyenNganhNavigation).WithMany(g => g.SinhViens).HasForeignKey(s => s.MaChuyenNganh).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<GiangVien>().HasOne<TaiKhoan>(s => s.TenTaiKhoanNavigation).WithMany(g => g.GiangViens).HasForeignKey(s => s.TenTaiKhoan).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<PhuHuynh>().HasOne<TaiKhoan>(s => s.TenTaiKhoanNavigation).WithMany(g => g.PhuHuynhs).HasForeignKey(s => s.TenTaiKhoan).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<CanBoDaoTao>().HasOne<TaiKhoan>(s => s.TenTaiKhoanNavigation).WithMany(g => g.CanBoDaoTaos).HasForeignKey(s => s.TenTaiKhoan).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<DiemSo>().HasOne<SinhVien>(s => s.MaSinhVienNavigation).WithMany(g => g.DiemSos).HasForeignKey(s => s.MaSinhVien).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<DiemSo>().HasOne<MonHoc>(s => s.MaMonHocNavigation).WithMany(g => g.DiemSos).HasForeignKey(s => s.MaMonHoc).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<DiemSo>().HasOne<GiangVien>(s => s.MaGiangVienNavigation).WithMany(g => g.DiemSos).HasForeignKey(s => s.MaGiangVien).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<DiemSo>().HasOne<Lop>(s => s.MaLopNavigation).WithMany(g => g.DiemSos).HasForeignKey(s => s.MaLop).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<GiangVienMonHoc>().HasOne<GiangVien>(s => s.MaGiangVienNavigation).WithMany(g => g.GiangVienMonHocs).HasForeignKey(s => s.MaGiangVien).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<GiangVienMonHoc>().HasOne<MonHoc>(s => s.MaMonHocNavigation).WithMany(g => g.GiangVienMonHocs).HasForeignKey(s => s.MaMonHoc).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChuyenNganhMonHoc>().HasOne<ChuyenNganh>(s => s.MaChuyenNganhNavigation).WithMany(g => g.ChuyenNganhMonHocs).HasForeignKey(s => s.MaChuyenNganh).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChuyenNganhMonHoc>().HasOne<MonHoc>(s => s.MaMonHocNavigation).WithMany(g => g.ChuyenNganhMonHocs).HasForeignKey(s => s.MaMonHoc).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<CanBoDaoTao>().HasKey(c => c.MaCanBoDaoTao);
            _ = builder.Entity<ChuyenNganh>().HasKey(c => c.MaChuyenNganh);
            _ = builder.Entity<GiangVien>().HasKey(c => c.MaGiangVien);
            _ = builder.Entity<Lop>().HasKey(c => c.MaLop);
            _ = builder.Entity<MonHoc>().HasKey(c => c.MaMonHoc);
            _ = builder.Entity<PhuHuynh>().HasKey(c => c.MaPhuHuynh);
            _ = builder.Entity<SinhVien>().HasKey(c => c.MaSinhVien);
            _ = builder.Entity<TaiKhoan>().HasKey(c => c.TenTaiKhoan);
            _ = builder.Entity<DiemSo>().HasKey(c => new { c.MaSinhVien, c.MaMonHoc });
            _ = builder.Entity<GiangVienMonHoc>().HasKey(c => new { c.MaGiangVien, c.MaMonHoc });
            _ = builder.Entity<ChuyenNganhMonHoc>().HasKey(c => new { c.MaChuyenNganh, c.MaMonHoc });
        }
        public virtual DbSet<CanBoDaoTao> CanBoDaoTaos { get; set; } = null!;
        public virtual DbSet<ChuyenNganh> ChuyenNganhs { get; set; } = null!;
        public virtual DbSet<DiemSo> DiemSos { get; set; } = null!;
        public virtual DbSet<GiangVien> GiangViens { get; set; } = null!;
        public virtual DbSet<GiangVienMonHoc> GiangVienMonHocs { get; set; } = null!;
        public virtual DbSet<ChuyenNganhMonHoc> ChuyenNganhMonHocs { get; set; } = null!;
        public virtual DbSet<Lop> Lops { get; set; } = null!;
        public virtual DbSet<MonHoc> MonHocs { get; set; } = null!;
        public virtual DbSet<PhuHuynh> PhuHuynhs { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
    }
}
