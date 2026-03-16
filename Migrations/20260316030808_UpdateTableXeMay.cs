using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableXeMay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 3);

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
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "NamSanXuat",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 2024,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2023);

            migrationBuilder.AlterColumn<string>(
                name: "MauSac",
                table: "SanPhams",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "N/A",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "N/A");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gia",
                table: "SanPhams",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 1,
                column: "GiaTaiThoiDiemDat",
                value: 115000000m);

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgayDat", "TongTien" },
                values: new object[] { new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 115000000m });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 115000000m, "https://cdn.honda.com.vn/motorbikes/october2023/X9A5O5O5O5O5.png", "Đen", 2024, 150, 5, "", "Honda SH 150i" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 52000000m, "https://yamaha-motor.com.vn/wp-content/uploads/2023/09/Exciter-155-VVA-moi-Xanh-GP.png", 2, "Xanh GP", 2024, 155, 10, "", "Yamaha Exciter 155 VVA" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MaHangXe", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 50000000m, "https://suzuki.com.vn/images/raider/hinh-anh-xe/xanh-den.png", 3, "Xanh", 150, 3, "", "Suzuki Raider R150" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 35000000m, "https://cdn.honda.com.vn/motorbikes/december2022/Vision_Standard.png", "Trắng", 2024, 110, 15, "", "Honda Vision 2024" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Gia", "GiaBan", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham", "TenXe" },
                values: new object[] { 0m, 29000000m, "https://yamaha-motor.com.vn/wp-content/uploads/2022/04/Janus-Standard-Trang.png", 2, "Trắng", 2024, 125, 8, "", "Yamaha Janus" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "MauSac",
                table: "SanPhams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "N/A",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "N/A");

            migrationBuilder.AlterColumn<int>(
                name: "Gia",
                table: "SanPhams",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "ChiTietDonHangs",
                keyColumn: "Id",
                keyValue: 1,
                column: "GiaTaiThoiDiemDat",
                value: 55000000m);

            migrationBuilder.UpdateData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgayDat", "TongTien" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 57990000m });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "NgayDat", "TongTien", "TrangThai", "UserId" },
                values: new object[] { 2, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000000m, "DangGiao", 2 });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gia", "HinhAnh", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 55000000, "https://cdn2.cellphones.com.vn/x/media/catalog/product/v/g/vga_35_.png", "", 2023, 0, 0, "VGA ASUS ROG Strix 4090" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gia", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 15000000, "https://kccshop.vn/media/product/28247_cpu_intel_core_i9_14900k.jpg", 1, "", 2023, 0, 0, "CPU Intel Core i9-14900K" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Gia", "HinhAnh", "MaHangXe", "MauSac", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 6500000, "https://memoryzone.com.vn/wp-content/uploads/2023/11/ram-pc-g-skill-trident-z5-rgb-64gb-32gbx2-ddr5-6400mhz-black-1.jpg", 1, "", 0, 0, "RAM G.Skill Trident Z5 RGB 64GB" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Gia", "HinhAnh", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 25000000, "https://product.hstatic.net/200000722513/product/z790-godlike_2195cfdc3f5748739e5b3e8bc5cca499_grande.png", "", 2023, 0, 0, "Mainboard MSI Z790 Godlike" });

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Gia", "HinhAnh", "MaHangXe", "MauSac", "NamSanXuat", "PhanKhoi", "SoLuongTon", "TenSanPham" },
                values: new object[] { 4500000, "https://image.hsv-tech.io/1920x0/tgdd/products/common/dc41820e-89ff-49c3-9476-65b8e16186bb.webp", 1, "", 2023, 0, 0, "SSD Samsung 990 Pro 2TB" });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "Gia", "HinhAnh", "MauSac", "TenSanPham" },
                values: new object[,]
                {
                    { 6, 4200000, "https://product.hstatic.net/200000722513/product/rm1000x_shift_4aacdb3c4a584e29b95d97d63f0e9bb5_grande.png", "", "Nguon Corsair RM1000x" },
                    { 7, 4000000, "https://nzxt.com/assets/cms/34299/1695426388-h9-flow-black-pdp-main-1.png", "", "Case NZXT H9 Flow" },
                    { 8, 32000000, "https://images.samsung.com/is/image/samsung/p6pim/vn/lc49g95tssexxv/gallery/vn-odyssey-g9-g95ts-lc49g95tssexxv-530838690", "", "Man hinh Samsung Odyssey G9" },
                    { 9, 3990000, "https://hyberx.com.vn/wp-content/uploads/2024/03/razer-viper-v3-pro.jpg", "", "Chuot Razer Viper V3 Pro" },
                    { 10, 2990000, "https://akko.vn/wp-content/uploads/2023/01/3098B-Plus-World-Tour-Tokyo-R2-1-scaled.jpg", "", "Phim co Akko MOD007" },
                    { 11, 32000000, "https://product.hstatic.net/200000722513/product/gv-n408saorus-m-16gd_a90c49c2c00441a5bdb9a461e9e7b34d_grande.png", "", "VGA Gigabyte AORUS RTX 4080 Super Master" },
                    { 12, 24500000, "https://product.hstatic.net/200000722513/product/rtx-4070-ti-super-16g-gaming-x-trio_38c96e04a0334ca388aa58d2b86e4c84_grande.png", "", "VGA MSI RTX 4070 Ti Super Gaming X Trio" },
                    { 13, 29000000, "https://memoryzone.com.vn/wp-content/uploads/2023/01/vga-sapphire-nitro-radeon-rx-7900-xtx-24gb-gddr6-1.jpg", "", "VGA Sapphire Nitro+ RX 7900 XTX" },
                    { 14, 17500000, "https://product.hstatic.net/200000722513/product/tuf-rtx4070-12g-gaming_b1d6e42d3e714e2295756a95e7cf1d81_grande.png", "", "VGA ASUS TUF Gaming RTX 4070" },
                    { 15, 11500000, "https://product.hstatic.net/200000722513/product/igame-geforce-rtx-4060-ti-ultra-w-duo-oc-8g-v2_09e8f8e6b56f433cba0e3ea76c8dca9b_grande.png", "", "VGA Colorful iGame RTX 4060 Ti Ultra W" },
                    { 16, 10500000, "https://image.hsv-tech.io/1920x0/tgdd/products/common/7e1add6c-9b3a-41a4-b53d-21de77742c88.webp", "", "CPU AMD Ryzen 7 7800X3D" },
                    { 17, 14500000, "https://memoryzone.com.vn/wp-content/uploads/2022/09/cpu-amd-ryzen-9-7950x-16-core-32-thread-1.jpg", "", "CPU AMD Ryzen 9 7950X" },
                    { 18, 11200000, "https://memoryzone.com.vn/wp-content/uploads/2023/10/cpu-intel-core-i7-14700k-box-1.jpg", "", "CPU Intel Core i7-14700K" },
                    { 19, 8200000, "https://memoryzone.com.vn/wp-content/uploads/2022/10/cpu-intel-core-i5-13600k-1.jpg", "", "CPU Intel Core i5-13600K" },
                    { 20, 6000000, "https://memoryzone.com.vn/wp-content/uploads/2022/09/cpu-amd-ryzen-5-7600x-6-core-12-thread-1.jpg", "", "CPU AMD Ryzen 5 7600X" },
                    { 21, 18000000, "https://product.hstatic.net/200000722513/product/rog-crosshair-x670e-hero_0f34a7f36c674b259ef3fcff7acea671_grande.png", "", "Mainboard ASUS ROG Crosshair X670E Hero" },
                    { 22, 6500000, "https://product.hstatic.net/200000722513/product/b650-aorus-elite-ax_c5d2cf2eb79e4b7a98ebc3c0d3a33d73_grande.png", "", "Mainboard Gigabyte B650 AORUS ELITE AX" },
                    { 23, 4800000, "https://product.hstatic.net/200000722513/product/mag-b760m-mortar-wifi_e11deef10e4b47e293dd2c5b3bca2979_grande.png", "", "Mainboard MSI MAG B760M MORTAR WIFI" },
                    { 24, 22000000, "https://www.lg.com/vn/images/monitors/md08003461/gallery/medium02.jpg", "", "Man hinh LG UltraGear 27GR95QE OLED 240Hz" },
                    { 25, 28500000, "https://i.dell.com/sites/csimages/App-Merchandizing_Images/all/aw3423dwf.png", "", "Man hinh Alienware AW3423DWF QD-OLED" },
                    { 26, 7500000, "https://dlcdnwebimgs.asus.com/gain/61e36f3f-08a3-4f6e-8a49-25b7bb4fa08e/", "", "Man hinh ASUS TUF Gaming VG27AQ 2K 165Hz" },
                    { 27, 16900000, "https://zowie.benq.com/content/dam/zowie/products/gaming-monitor/xl2566k/xl2566k_pdp_01.jpg", "", "Man hinh BenQ Zowie XL2566K 360Hz" },
                    { 28, 3790000, "https://resource.logitech.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/logitech/en/products/mice/g-pro-x-superlight-2/gallery/g-pro-x-superlight-2-top-black.png", "", "Chuot Logitech G Pro X Superlight 2" },
                    { 29, 3590000, "https://hyberx.com.vn/wp-content/uploads/2023/03/razer-deathadder-v3-pro-black.jpg", "", "Chuot Razer DeathAdder V3 Pro" },
                    { 30, 3990000, "https://zowie.benq.com/content/dam/zowie/products/mouse/ec2-cw/ec2-cw_pdp_01.jpg", "", "Chuot Zowie EC2-CW Wireless" },
                    { 31, 2400000, "https://www.pulsargg.com/cdn/shop/files/X2V2_Mini_Wireless_Black_1.jpg", "", "Chuot Pulsar X2V2 Mini Wireless" },
                    { 32, 5500000, "https://wooting.io/wp-content/uploads/2022/09/60HE-hero-side-right-3.png", "", "Ban phim Wooting 60HE Analog" },
                    { 33, 4900000, "https://cdn.shopify.com/s/files/1/0059/0630/1017/files/Keychron-Q1-Pro-QMK-VIA-wireless-custom-mechanical-keyboard-for-Mac-and-Windows-with-hot-swappable-keychron-K-Pro-switch-carbon-black.jpg", "", "Ban phim Keychron Q1 Pro Wireless Custom" },
                    { 34, 5200000, "https://www.corsair.com/medias/sys_master/images/images/hb1/hf3/9543022723102/CH-9109411-NA-Gallery-K70-MAX-RGB-01.png", "", "Ban phim Corsair K70 MAX Magnetic" },
                    { 35, 4500000, "https://hyberx.com.vn/wp-content/uploads/2023/11/razer-huntsman-v3-pro-tkl.jpg", "", "Ban phim Razer Huntsman V3 Pro TKL" },
                    { 36, 3990000, "https://media.kingston.com/hyperx/product/hx-product-headset-cloud-iii-wireless-black-1-zm-lg.jpg", "", "Tai nghe HyperX Cloud III Wireless" },
                    { 37, 3200000, "https://resource.logitech.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/logitech/en/products/gaming-headsets/g733/gallery/g733-lightspeed-gallery-1-black.png", "", "Tai nghe Logitech G733 Lightspeed" },
                    { 38, 5200000, "https://www.corsair.com/medias/sys_master/images/images/h0e/h24/9467887575070/CMP32GX5M2B6000C30-Gallery-Dominator-Titanium-DDR5-RGB-Black-01.png", "", "RAM Corsair Dominator Titanium 32GB 6000MHz" },
                    { 39, 3800000, "https://seasonic.com/uploads/products/FOCUS-GX-850_01.png", "", "Nguon Seasonic Focus GX-850 850W Gold" },
                    { 40, 7500000, "https://nzxt.com/assets/cms/34299/1662485331-kraken-elite-rgb-360-black-pdp-main-1.png", "", "Tan nhiet nuoc NZXT Kraken Elite 360 RGB" }
                });

            migrationBuilder.InsertData(
                table: "ChiTietDonHangs",
                columns: new[] { "Id", "DonHangId", "GiaTaiThoiDiemDat", "SanPhamId", "SoLuong" },
                values: new object[,]
                {
                    { 2, 1, 2990000m, 10, 1 },
                    { 3, 2, 25000000m, 4, 1 }
                });
        }
    }
}
