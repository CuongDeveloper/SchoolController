using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolController.Migrations
{
    /// <inheritdoc />
    public partial class createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "ChuyenNganhs",
                columns: table => new
                {
                    MaChuyenNganh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChuyenNganhs", x => x.MaChuyenNganh);
                });

            _ = migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Lops", x => x.MaLop);
                });

            _ = migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_MonHocs", x => x.MaMonHoc);
                });

            _ = migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_TaiKhoans", x => x.TenTaiKhoan);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChuyenNganhMonHocs",
                columns: table => new
                {
                    MaChuyenNganh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChuyenNganhMonHocs", x => new { x.MaChuyenNganh, x.MaMonHoc });
                    _ = table.ForeignKey(
                        name: "FK_ChuyenNganhMonHocs_ChuyenNganhs_MaChuyenNganh",
                        column: x => x.MaChuyenNganh,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "MaChuyenNganh",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChuyenNganhMonHocs_MonHocs_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "CanBoDaoTaos",
                columns: table => new
                {
                    MaCanBoDaoTao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCanBoDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_CanBoDaoTaos", x => x.MaCanBoDaoTao);
                    _ = table.ForeignKey(
                        name: "FK_CanBoDaoTaos_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "GiangViens",
                columns: table => new
                {
                    MaGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGiangVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_GiangViens", x => x.MaGiangVien);
                    _ = table.ForeignKey(
                        name: "FK_GiangViens_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "PhuHuynhs",
                columns: table => new
                {
                    MaPhuHuynh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_PhuHuynhs", x => x.MaPhuHuynh);
                    _ = table.ForeignKey(
                        name: "FK_PhuHuynhs_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "GiangVienMonHocs",
                columns: table => new
                {
                    MaGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DanhGia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_GiangVienMonHocs", x => new { x.MaGiangVien, x.MaMonHoc });
                    _ = table.ForeignKey(
                        name: "FK_GiangVienMonHocs_GiangViens_MaGiangVien",
                        column: x => x.MaGiangVien,
                        principalTable: "GiangViens",
                        principalColumn: "MaGiangVien",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_GiangVienMonHocs_MonHocs_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSinhVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPhuHuynh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaChuyenNganh = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_SinhViens", x => x.MaSinhVien);
                    _ = table.ForeignKey(
                        name: "FK_SinhViens_ChuyenNganhs_MaChuyenNganh",
                        column: x => x.MaChuyenNganh,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "MaChuyenNganh",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_SinhViens_PhuHuynhs_MaPhuHuynh",
                        column: x => x.MaPhuHuynh,
                        principalTable: "PhuHuynhs",
                        principalColumn: "MaPhuHuynh",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_SinhViens_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "DiemSos",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DiemSos", x => new { x.MaSinhVien, x.MaMonHoc });
                    _ = table.ForeignKey(
                        name: "FK_DiemSos_GiangViens_MaGiangVien",
                        column: x => x.MaGiangVien,
                        principalTable: "GiangViens",
                        principalColumn: "MaGiangVien",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_DiemSos_Lops_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lops",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_DiemSos_MonHocs_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_DiemSos_SinhViens_MaSinhVien",
                        column: x => x.MaSinhVien,
                        principalTable: "SinhViens",
                        principalColumn: "MaSinhVien",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_CanBoDaoTaos_TenTaiKhoan",
                table: "CanBoDaoTaos",
                column: "TenTaiKhoan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganhMonHocs_MaMonHoc",
                table: "ChuyenNganhMonHocs",
                column: "MaMonHoc");

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemSos_MaGiangVien",
                table: "DiemSos",
                column: "MaGiangVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemSos_MaLop",
                table: "DiemSos",
                column: "MaLop");

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemSos_MaMonHoc",
                table: "DiemSos",
                column: "MaMonHoc");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiangVienMonHocs_MaMonHoc",
                table: "GiangVienMonHocs",
                column: "MaMonHoc");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiangViens_TenTaiKhoan",
                table: "GiangViens",
                column: "TenTaiKhoan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_PhuHuynhs_TenTaiKhoan",
                table: "PhuHuynhs",
                column: "TenTaiKhoan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaChuyenNganh",
                table: "SinhViens",
                column: "MaChuyenNganh");

            _ = migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaPhuHuynh",
                table: "SinhViens",
                column: "MaPhuHuynh");

            _ = migrationBuilder.CreateIndex(
                name: "IX_SinhViens_TenTaiKhoan",
                table: "SinhViens",
                column: "TenTaiKhoan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "CanBoDaoTaos");

            _ = migrationBuilder.DropTable(
                name: "ChuyenNganhMonHocs");

            _ = migrationBuilder.DropTable(
                name: "DiemSos");

            _ = migrationBuilder.DropTable(
                name: "GiangVienMonHocs");

            _ = migrationBuilder.DropTable(
                name: "Lops");

            _ = migrationBuilder.DropTable(
                name: "SinhViens");

            _ = migrationBuilder.DropTable(
                name: "GiangViens");

            _ = migrationBuilder.DropTable(
                name: "MonHocs");

            _ = migrationBuilder.DropTable(
                name: "ChuyenNganhs");

            _ = migrationBuilder.DropTable(
                name: "PhuHuynhs");

            _ = migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
