using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMotorcycleFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaHangXe",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "MauSac",
                table: "SanPhams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "N/A");

            migrationBuilder.AddColumn<int>(
                name: "NamSanXuat",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 2023);

            migrationBuilder.AddColumn<int>(
                name: "PhanKhoi",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongTon",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HangXes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangXes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayDat",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayDat",
                value: new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "HangXes",
                columns: new[] { "Id", "TenHang" },
                values: new object[,]
                {
                    { 1, "Honda" },
                    { 2, "Yamaha" },
                    { 3, "Suzuki" }
                });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Nguon Corsair RM1000x" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 7,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Man hinh Samsung Odyssey G9" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Chuot Razer Viper V3 Pro" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Phim co Akko MOD007" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 11,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 12,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 13,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 14,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 15,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 16,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 17,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 18,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 19,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 20,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 21,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 22,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 23,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Man hinh LG UltraGear 27GR95QE OLED 240Hz" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Man hinh Alienware AW3423DWF QD-OLED" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Man hinh ASUS TUF Gaming VG27AQ 2K 165Hz" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Man hinh BenQ Zowie XL2566K 360Hz" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Chuot Logitech G Pro X Superlight 2" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Chuot Razer DeathAdder V3 Pro" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Chuot Zowie EC2-CW Wireless" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Chuot Pulsar X2V2 Mini Wireless" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Ban phim Wooting 60HE Analog" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Ban phim Keychron Q1 Pro Wireless Custom" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Ban phim Corsair K70 MAX Magnetic" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Ban phim Razer Huntsman V3 Pro TKL" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 36,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 37,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 38,
                column: "MauSac",
                value: "");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Nguon Seasonic Focus GX-850 850W Gold" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "MauSac", "TenSanPham" },
                values: new object[] { "", "Tan nhiet nuoc NZXT Kraken Elite 360 RGB" });

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaHangXe",
                table: "SanPhams",
                column: "MaHangXe");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_HangXes_MaHangXe",
                table: "SanPhams",
                column: "MaHangXe",
                principalTable: "HangXes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_HangXes_MaHangXe",
                table: "SanPhams");

            migrationBuilder.DropTable(
                name: "HangXes");

            migrationBuilder.DropIndex(
                name: "IX_SanPhams_MaHangXe",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "MaHangXe",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "MauSac",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "NamSanXuat",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "PhanKhoi",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "SoLuongTon",
                table: "SanPhams");

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayDat",
                value: new DateTime(2026, 3, 10, 16, 13, 14, 213, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayDat",
                value: new DateTime(2026, 3, 11, 16, 13, 14, 213, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2026, 3, 12, 16, 13, 14, 213, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2026, 3, 12, 16, 13, 14, 213, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 6,
                column: "TenSanPham",
                value: "Nguồn Corsair RM1000x");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 8,
                column: "TenSanPham",
                value: "Màn hình Samsung Odyssey G9");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 9,
                column: "TenSanPham",
                value: "Chuột Razer Viper V3 Pro");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 10,
                column: "TenSanPham",
                value: "Phím cơ Akko MOD007");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 24,
                column: "TenSanPham",
                value: "Màn hình LG UltraGear 27GR95QE OLED 240Hz");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 25,
                column: "TenSanPham",
                value: "Màn hình Alienware AW3423DWF QD-OLED");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 26,
                column: "TenSanPham",
                value: "Màn hình ASUS TUF Gaming VG27AQ 2K 165Hz");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 27,
                column: "TenSanPham",
                value: "Màn hình BenQ Zowie XL2566K 360Hz");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 28,
                column: "TenSanPham",
                value: "Chuột Logitech G Pro X Superlight 2");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 29,
                column: "TenSanPham",
                value: "Chuột Razer DeathAdder V3 Pro");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 30,
                column: "TenSanPham",
                value: "Chuột Zowie EC2-CW Wireless");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 31,
                column: "TenSanPham",
                value: "Chuột Pulsar X2V2 Mini Wireless");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 32,
                column: "TenSanPham",
                value: "Bàn phím Wooting 60HE Analog");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 33,
                column: "TenSanPham",
                value: "Bàn phím Keychron Q1 Pro Wireless Custom");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 34,
                column: "TenSanPham",
                value: "Bàn phím Corsair K70 MAX Magnetic");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 35,
                column: "TenSanPham",
                value: "Bàn phím Razer Huntsman V3 Pro TKL");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 39,
                column: "TenSanPham",
                value: "Nguồn Seasonic Focus GX-850 850W Gold");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 40,
                column: "TenSanPham",
                value: "Tản nhiệt nước NZXT Kraken Elite 360 RGB");
        }
    }
}
