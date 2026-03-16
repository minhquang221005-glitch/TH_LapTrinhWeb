using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class FixXeMayCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiaBan",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "TenXe",
                table: "SanPhams");

            migrationBuilder.AlterColumn<int>(
                name: "NamSanXuat",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 2023,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2024);

            migrationBuilder.AlterColumn<decimal>(
                name: "Gia",
                table: "SanPhams",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TongTien",
                table: "DonHangs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaTaiThoiDiemDat",
                table: "ChiTietDonHangs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GiaTaiThoiDiemDat", "SanPhamId" },
                values: new object[] { 38900000m, 2 });

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgayDat", "TongTien" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 38900000m });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "NgayDat", "TongTien", "TrangThai", "UserId" },
                values: new object[] { 2, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 52990000m, "DangGiao", 2 });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "admin@xemaystore.com");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gia", "HinhAnh", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 18900000m, "https://www.honda.com.vn/uploads/products/wave-alpha/wave-alpha-do-den.png", "Do", 110, 10, "Honda Wave Alpha 110" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gia", "HinhAnh", "MaHangXe", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 38900000m, "https://www.honda.com.vn/uploads/products/air-blade/air-blade-125-special-den-do.png", 1, "Den", 125, 8, "Honda Air Blade 125" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Gia", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 30900000m, "https://www.honda.com.vn/uploads/products/vision/vision-do-den.png", 1, "Do", 2024, 110, 15, "Honda Vision 110" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Gia", "HinhAnh", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 70900000m, "https://www.honda.com.vn/uploads/products/sh150i/sh150i-trang.png", "Trang", 150, 5, "Honda SH 150i" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Gia", "HinhAnh", "MaHangXe", "MauSac", "SoLuongTon", "TenSanPham" },
                values: new object[] { 52900000m, "https://www.honda.com.vn/uploads/products/pcx/pcx125-den.png", 1, "Den", 7, "Honda PCX 125" });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "Gia", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { 6, 68000000m, "https://www.honda.com.vn/uploads/products/cb150r/cb150r-den.png", 1, "Den", 2023, 150, 4, "Honda CB150R" },
                    { 7, 46900000m, "https://www.honda.com.vn/uploads/products/winner-x/winner-x-trang-do.png", 1, "Trang", 2024, 150, 6, "Honda Winner X 150" },
                    { 8, 52990000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/exciter-155-vva.png", 2, "Xanh", 2024, 155, 9, "Yamaha Exciter 155 VVA" },
                    { 9, 53990000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/nvx155-vva.png", 2, "Den", 2024, 155, 7, "Yamaha NVX 155 VVA" },
                    { 10, 48990000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/grande-125-hybrid.png", 2, "Trang", 2024, 125, 8, "Yamaha Grande 125 Hybrid" },
                    { 11, 31490000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/janus-125.png", 2, "Hong", 2023, 125, 12, "Yamaha Janus 125" },
                    { 12, 38990000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/freego-125.png", 2, "Xanh", 2023, 125, 6, "Yamaha Freego 125" },
                    { 13, 98000000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/r15-v4.png", 2, "Xanh", 2024, 155, 3, "Yamaha R15 V4" },
                    { 14, 94000000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/mt15-v2.png", 2, "Den", 2024, 155, 4, "Yamaha MT-15 V2" },
                    { 15, 52990000m, "https://suzuki.com.vn/wp-content/uploads/2021/06/raider-r150.png", 3, "Trang", 2023, 150, 5, "Suzuki Raider R150 Fi" },
                    { 16, 28500000m, "https://suzuki.com.vn/wp-content/uploads/2021/06/hayate-125.png", 3, "Xam", 2023, 125, 8, "Suzuki Hayate 125" },
                    { 17, 21990000m, "https://suzuki.com.vn/wp-content/uploads/2021/06/address-110.png", 3, "Trang", 2023, 110, 10, "Suzuki Address 110" },
                    { 18, 79000000m, "https://suzuki.com.vn/wp-content/uploads/2021/06/gsx-r150.png", 3, "Xanh", 2023, 150, 3, "Suzuki GSX-R150" },
                    { 19, 37900000m, "https://www.honda.com.vn/uploads/products/lead/lead-125-do-den.png", 1, "Do", 2024, 125, 9, "Honda Lead 125" },
                    { 20, 21490000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/sirius-115-fi.png", 2, "Den", 2023, 115, 14, "Yamaha Sirius 115 Fi" }
                });

            migrationBuilder.InsertData(
                table: "ChiTietDonHangs",
                columns: new[] { "Id", "DonHangId", "GiaTaiThoiDiemDat", "SanPhamId", "SoLuong" },
                values: new object[] { 2, 2, 52990000m, 8, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<int>(
                name: "NamSanXuat",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 2024,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2023);

            migrationBuilder.AlterColumn<decimal>(
                name: "Gia",
                table: "SanPhams",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AddColumn<decimal>(
                name: "GiaBan",
                table: "SanPhams",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TenXe",
                table: "SanPhams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "TongTien",
                table: "DonHangs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaTaiThoiDiemDat",
                table: "ChiTietDonHangs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.UpdateData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GiaTaiThoiDiemDat", "SanPhamId" },
                values: new object[] { 115000000m, 1 });

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgayDat", "TongTien" },
                values: new object[] { new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 115000000m });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "admin@thinhpc.com");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 115000000m, "https://cdn.honda.com.vn/motorbikes/october2023/X9A5O5O5O5O5.png", "Đen", 150, 5, "", "Honda SH 150i" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MaHangXe", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 52000000m, "https://yamaha-motor.com.vn/wp-content/uploads/2023/09/Exciter-155-VVA-moi-Xanh-GP.png", 2, "Xanh GP", 155, 10, "", "Yamaha Exciter 155 VVA" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 50000000m, "https://suzuki.com.vn/images/raider/hinh-anh-xe/xanh-den.png", 3, "Xanh", 2023, 150, 3, "", "Suzuki Raider R150" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 35000000m, "https://cdn.honda.com.vn/motorbikes/december2022/Vision_Standard.png", "Trắng", 110, 15, "", "Honda Vision 2024" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MaHangXe", "MauSac", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 29000000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/04/Janus-Standard-Trang.png", 2, "Trắng", 8, "", "Yamaha Janus" });
        }
    }
}
