using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class NhapThem30MonHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "Gia", "TenSanPham" },
                values: new object[,]
                {
                    { 11, 32000000, "VGA Gigabyte AORUS RTX 4080 Super Master" },
                    { 12, 24500000, "VGA MSI RTX 4070 Ti Super Gaming X Trio" },
                    { 13, 29000000, "VGA Sapphire Nitro+ RX 7900 XTX" },
                    { 14, 17500000, "VGA ASUS TUF Gaming RTX 4070" },
                    { 15, 11500000, "VGA Colorful iGame RTX 4060 Ti Ultra W" },
                    { 16, 10500000, "CPU AMD Ryzen 7 7800X3D" },
                    { 17, 14500000, "CPU AMD Ryzen 9 7950X" },
                    { 18, 11200000, "CPU Intel Core i7-14700K" },
                    { 19, 8200000, "CPU Intel Core i5-13600K" },
                    { 20, 6000000, "CPU AMD Ryzen 5 7600X" },
                    { 21, 18000000, "Mainboard ASUS ROG Crosshair X670E Hero" },
                    { 22, 6500000, "Mainboard Gigabyte B650 AORUS ELITE AX" },
                    { 23, 4800000, "Mainboard MSI MAG B760M MORTAR WIFI" },
                    { 24, 22000000, "Màn hình LG UltraGear 27GR95QE OLED 240Hz" },
                    { 25, 28500000, "Màn hình Alienware AW3423DWF QD-OLED" },
                    { 26, 7500000, "Màn hình ASUS TUF Gaming VG27AQ 2K 165Hz" },
                    { 27, 16900000, "Màn hình BenQ Zowie XL2566K 360Hz" },
                    { 28, 3790000, "Chuột Logitech G Pro X Superlight 2" },
                    { 29, 3590000, "Chuột Razer DeathAdder V3 Pro" },
                    { 30, 3990000, "Chuột Zowie EC2-CW Wireless" },
                    { 31, 2400000, "Chuột Pulsar X2V2 Mini Wireless" },
                    { 32, 5500000, "Bàn phím Wooting 60HE Analog" },
                    { 33, 4900000, "Bàn phím Keychron Q1 Pro Wireless Custom" },
                    { 34, 5200000, "Bàn phím Corsair K70 MAX Magnetic" },
                    { 35, 4500000, "Bàn phím Razer Huntsman V3 Pro TKL" },
                    { 36, 3990000, "Tai nghe HyperX Cloud III Wireless" },
                    { 37, 3200000, "Tai nghe Logitech G733 Lightspeed" },
                    { 38, 5200000, "RAM Corsair Dominator Titanium 32GB 6000MHz" },
                    { 39, 3800000, "Nguồn Seasonic Focus GX-850 850W Gold" },
                    { 40, 7500000, "Tản nhiệt nước NZXT Kraken Elite 360 RGB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
