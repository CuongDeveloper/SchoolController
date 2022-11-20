using System;
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
            migrationBuilder.CreateTable(
                name: "ChuyenNganhs",
                columns: table => new
                {
                    MaChuyenNganh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganhs", x => x.MaChuyenNganh);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocs", x => x.MaMonHoc);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.TenTaiKhoan);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganhMonHocs",
                columns: table => new
                {
                    MaChuyenNganh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganhMonHocs", x => new { x.MaChuyenNganh, x.MaMonHoc });
                    table.ForeignKey(
                        name: "FK_ChuyenNganhMonHocs_ChuyenNganhs_MaChuyenNganh",
                        column: x => x.MaChuyenNganh,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "MaChuyenNganh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChuyenNganhMonHocs_MonHocs_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
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
                    table.PrimaryKey("PK_CanBoDaoTaos", x => x.MaCanBoDaoTao);
                    table.ForeignKey(
                        name: "FK_CanBoDaoTaos_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
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
                    table.PrimaryKey("PK_GiangViens", x => x.MaGiangVien);
                    table.ForeignKey(
                        name: "FK_GiangViens_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
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
                    table.PrimaryKey("PK_PhuHuynhs", x => x.MaPhuHuynh);
                    table.ForeignKey(
                        name: "FK_PhuHuynhs_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiangVienMonHocs",
                columns: table => new
                {
                    MaGiangVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DanhGia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVienMonHocs", x => new { x.MaGiangVien, x.MaMonHoc });
                    table.ForeignKey(
                        name: "FK_GiangVienMonHocs_GiangViens_MaGiangVien",
                        column: x => x.MaGiangVien,
                        principalTable: "GiangViens",
                        principalColumn: "MaGiangVien",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GiangVienMonHocs_MonHocs_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
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
                    table.PrimaryKey("PK_SinhViens", x => x.MaSinhVien);
                    table.ForeignKey(
                        name: "FK_SinhViens_ChuyenNganhs_MaChuyenNganh",
                        column: x => x.MaChuyenNganh,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "MaChuyenNganh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SinhViens_PhuHuynhs_MaPhuHuynh",
                        column: x => x.MaPhuHuynh,
                        principalTable: "PhuHuynhs",
                        principalColumn: "MaPhuHuynh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SinhViens_TaiKhoans_TenTaiKhoan",
                        column: x => x.TenTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
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
                    table.PrimaryKey("PK_DiemSos", x => new { x.MaSinhVien, x.MaMonHoc });
                    table.ForeignKey(
                        name: "FK_DiemSos_GiangViens_MaGiangVien",
                        column: x => x.MaGiangVien,
                        principalTable: "GiangViens",
                        principalColumn: "MaGiangVien",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiemSos_Lops_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lops",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiemSos_MonHocs_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiemSos_SinhViens_MaSinhVien",
                        column: x => x.MaSinhVien,
                        principalTable: "SinhViens",
                        principalColumn: "MaSinhVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanBoDaoTaos_TenTaiKhoan",
                table: "CanBoDaoTaos",
                column: "TenTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganhMonHocs_MaMonHoc",
                table: "ChuyenNganhMonHocs",
                column: "MaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DiemSos_MaGiangVien",
                table: "DiemSos",
                column: "MaGiangVien");

            migrationBuilder.CreateIndex(
                name: "IX_DiemSos_MaLop",
                table: "DiemSos",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_DiemSos_MaMonHoc",
                table: "DiemSos",
                column: "MaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVienMonHocs_MaMonHoc",
                table: "GiangVienMonHocs",
                column: "MaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_GiangViens_TenTaiKhoan",
                table: "GiangViens",
                column: "TenTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_PhuHuynhs_TenTaiKhoan",
                table: "PhuHuynhs",
                column: "TenTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaChuyenNganh",
                table: "SinhViens",
                column: "MaChuyenNganh");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaPhuHuynh",
                table: "SinhViens",
                column: "MaPhuHuynh");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_TenTaiKhoan",
                table: "SinhViens",
                column: "TenTaiKhoan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanBoDaoTaos");

            migrationBuilder.DropTable(
                name: "ChuyenNganhMonHocs");

            migrationBuilder.DropTable(
                name: "DiemSos");

            migrationBuilder.DropTable(
                name: "GiangVienMonHocs");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "GiangViens");

            migrationBuilder.DropTable(
                name: "MonHocs");

            migrationBuilder.DropTable(
                name: "ChuyenNganhs");

            migrationBuilder.DropTable(
                name: "PhuHuynhs");

            migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
