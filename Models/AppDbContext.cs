using Microsoft.EntityFrameworkCore;

namespace Buoi1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SanPham>().HasData(
                // --- 10 MÓN CŨ ---
                new SanPham { Id = 1, TenSanPham = "VGA ASUS ROG Strix 4090", Gia = 55000000, HinhAnh = "https://cdn2.cellphones.com.vn/x/media/catalog/product/v/g/vga_35_.png" },
                new SanPham { Id = 2, TenSanPham = "CPU Intel Core i9-14900K", Gia = 15000000, HinhAnh = "https://kccshop.vn/media/product/28247_cpu_intel_core_i9_14900k.jpg" },
                new SanPham { Id = 3, TenSanPham = "RAM G.Skill Trident Z5 RGB 64GB", Gia = 6500000, HinhAnh = "https://memoryzone.com.vn/wp-content/uploads/2023/11/ram-pc-g-skill-trident-z5-rgb-64gb-32gbx2-ddr5-6400mhz-black-1.jpg" },
                new SanPham { Id = 4, TenSanPham = "Mainboard MSI Z790 Godlike", Gia = 25000000, HinhAnh = "https://product.hstatic.net/200000722513/product/z790-godlike_2195cfdc3f5748739e5b3e8bc5cca499_grande.png" },
                new SanPham { Id = 5, TenSanPham = "SSD Samsung 990 Pro 2TB", Gia = 4500000, HinhAnh = "https://image.hsv-tech.io/1920x0/tgdd/products/common/dc41820e-89ff-49c3-9476-65b8e16186bb.webp" },
                new SanPham { Id = 6, TenSanPham = "Nguồn Corsair RM1000x", Gia = 4200000, HinhAnh = "https://product.hstatic.net/200000722513/product/rm1000x_shift_4aacdb3c4a584e29b95d97d63f0e9bb5_grande.png" },
                new SanPham { Id = 7, TenSanPham = "Case NZXT H9 Flow", Gia = 4000000, HinhAnh = "https://nzxt.com/assets/cms/34299/1695426388-h9-flow-black-pdp-main-1.png" },
                new SanPham { Id = 8, TenSanPham = "Màn hình Samsung Odyssey G9", Gia = 32000000, HinhAnh = "https://images.samsung.com/is/image/samsung/p6pim/vn/lc49g95tssexxv/gallery/vn-odyssey-g9-g95ts-lc49g95tssexxv-530838690" },
                new SanPham { Id = 9, TenSanPham = "Chuột Razer Viper V3 Pro", Gia = 3990000, HinhAnh = "https://hyberx.com.vn/wp-content/uploads/2024/03/razer-viper-v3-pro.jpg" },
                new SanPham { Id = 10, TenSanPham = "Phím cơ Akko MOD007", Gia = 2990000, HinhAnh = "https://akko.vn/wp-content/uploads/2023/01/3098B-Plus-World-Tour-Tokyo-R2-1-scaled.jpg" },

                // --- VGA ---
                new SanPham { Id = 11, TenSanPham = "VGA Gigabyte AORUS RTX 4080 Super Master", Gia = 32000000, HinhAnh = "https://product.hstatic.net/200000722513/product/gv-n408saorus-m-16gd_a90c49c2c00441a5bdb9a461e9e7b34d_grande.png" },
                new SanPham { Id = 12, TenSanPham = "VGA MSI RTX 4070 Ti Super Gaming X Trio", Gia = 24500000, HinhAnh = "https://product.hstatic.net/200000722513/product/rtx-4070-ti-super-16g-gaming-x-trio_38c96e04a0334ca388aa58d2b86e4c84_grande.png" },
                new SanPham { Id = 13, TenSanPham = "VGA Sapphire Nitro+ RX 7900 XTX", Gia = 29000000, HinhAnh = "https://memoryzone.com.vn/wp-content/uploads/2023/01/vga-sapphire-nitro-radeon-rx-7900-xtx-24gb-gddr6-1.jpg" },
                new SanPham { Id = 14, TenSanPham = "VGA ASUS TUF Gaming RTX 4070", Gia = 17500000, HinhAnh = "https://product.hstatic.net/200000722513/product/tuf-rtx4070-12g-gaming_b1d6e42d3e714e2295756a95e7cf1d81_grande.png" },
                new SanPham { Id = 15, TenSanPham = "VGA Colorful iGame RTX 4060 Ti Ultra W", Gia = 11500000, HinhAnh = "https://product.hstatic.net/200000722513/product/igame-geforce-rtx-4060-ti-ultra-w-duo-oc-8g-v2_09e8f8e6b56f433cba0e3ea76c8dca9b_grande.png" },

                // --- CPU ---
                new SanPham { Id = 16, TenSanPham = "CPU AMD Ryzen 7 7800X3D", Gia = 10500000, HinhAnh = "https://image.hsv-tech.io/1920x0/tgdd/products/common/7e1add6c-9b3a-41a4-b53d-21de77742c88.webp" },
                new SanPham { Id = 17, TenSanPham = "CPU AMD Ryzen 9 7950X", Gia = 14500000, HinhAnh = "https://memoryzone.com.vn/wp-content/uploads/2022/09/cpu-amd-ryzen-9-7950x-16-core-32-thread-1.jpg" },
                new SanPham { Id = 18, TenSanPham = "CPU Intel Core i7-14700K", Gia = 11200000, HinhAnh = "https://memoryzone.com.vn/wp-content/uploads/2023/10/cpu-intel-core-i7-14700k-box-1.jpg" },
                new SanPham { Id = 19, TenSanPham = "CPU Intel Core i5-13600K", Gia = 8200000, HinhAnh = "https://memoryzone.com.vn/wp-content/uploads/2022/10/cpu-intel-core-i5-13600k-1.jpg" },
                new SanPham { Id = 20, TenSanPham = "CPU AMD Ryzen 5 7600X", Gia = 6000000, HinhAnh = "https://memoryzone.com.vn/wp-content/uploads/2022/09/cpu-amd-ryzen-5-7600x-6-core-12-thread-1.jpg" },

                // --- Mainboard ---
                new SanPham { Id = 21, TenSanPham = "Mainboard ASUS ROG Crosshair X670E Hero", Gia = 18000000, HinhAnh = "https://product.hstatic.net/200000722513/product/rog-crosshair-x670e-hero_0f34a7f36c674b259ef3fcff7acea671_grande.png" },
                new SanPham { Id = 22, TenSanPham = "Mainboard Gigabyte B650 AORUS ELITE AX", Gia = 6500000, HinhAnh = "https://product.hstatic.net/200000722513/product/b650-aorus-elite-ax_c5d2cf2eb79e4b7a98ebc3c0d3a33d73_grande.png" },
                new SanPham { Id = 23, TenSanPham = "Mainboard MSI MAG B760M MORTAR WIFI", Gia = 4800000, HinhAnh = "https://product.hstatic.net/200000722513/product/mag-b760m-mortar-wifi_e11deef10e4b47e293dd2c5b3bca2979_grande.png" },

                // --- Màn hình ---
                new SanPham { Id = 24, TenSanPham = "Màn hình LG UltraGear 27GR95QE OLED 240Hz", Gia = 22000000, HinhAnh = "https://www.lg.com/vn/images/monitors/md08003461/gallery/medium02.jpg" },
                new SanPham { Id = 25, TenSanPham = "Màn hình Alienware AW3423DWF QD-OLED", Gia = 28500000, HinhAnh = "https://i.dell.com/sites/csimages/App-Merchandizing_Images/all/aw3423dwf.png" },
                new SanPham { Id = 26, TenSanPham = "Màn hình ASUS TUF Gaming VG27AQ 2K 165Hz", Gia = 7500000, HinhAnh = "https://dlcdnwebimgs.asus.com/gain/61e36f3f-08a3-4f6e-8a49-25b7bb4fa08e/" },
                new SanPham { Id = 27, TenSanPham = "Màn hình BenQ Zowie XL2566K 360Hz", Gia = 16900000, HinhAnh = "https://zowie.benq.com/content/dam/zowie/products/gaming-monitor/xl2566k/xl2566k_pdp_01.jpg" },

                // --- Chuột ---
                new SanPham { Id = 28, TenSanPham = "Chuột Logitech G Pro X Superlight 2", Gia = 3790000, HinhAnh = "https://resource.logitech.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/logitech/en/products/mice/g-pro-x-superlight-2/gallery/g-pro-x-superlight-2-top-black.png" },
                new SanPham { Id = 29, TenSanPham = "Chuột Razer DeathAdder V3 Pro", Gia = 3590000, HinhAnh = "https://hyberx.com.vn/wp-content/uploads/2023/03/razer-deathadder-v3-pro-black.jpg" },
                new SanPham { Id = 30, TenSanPham = "Chuột Zowie EC2-CW Wireless", Gia = 3990000, HinhAnh = "https://zowie.benq.com/content/dam/zowie/products/mouse/ec2-cw/ec2-cw_pdp_01.jpg" },
                new SanPham { Id = 31, TenSanPham = "Chuột Pulsar X2V2 Mini Wireless", Gia = 2400000, HinhAnh = "https://www.pulsargg.com/cdn/shop/files/X2V2_Mini_Wireless_Black_1.jpg" },

                // --- Bàn phím ---
                new SanPham { Id = 32, TenSanPham = "Bàn phím Wooting 60HE Analog", Gia = 5500000, HinhAnh = "https://wooting.io/wp-content/uploads/2022/09/60HE-hero-side-right-3.png" },
                new SanPham { Id = 33, TenSanPham = "Bàn phím Keychron Q1 Pro Wireless Custom", Gia = 4900000, HinhAnh = "https://cdn.shopify.com/s/files/1/0059/0630/1017/files/Keychron-Q1-Pro-QMK-VIA-wireless-custom-mechanical-keyboard-for-Mac-and-Windows-with-hot-swappable-keychron-K-Pro-switch-carbon-black.jpg" },
                new SanPham { Id = 34, TenSanPham = "Bàn phím Corsair K70 MAX Magnetic", Gia = 5200000, HinhAnh = "https://www.corsair.com/medias/sys_master/images/images/hb1/hf3/9543022723102/CH-9109411-NA-Gallery-K70-MAX-RGB-01.png" },
                new SanPham { Id = 35, TenSanPham = "Bàn phím Razer Huntsman V3 Pro TKL", Gia = 4500000, HinhAnh = "https://hyberx.com.vn/wp-content/uploads/2023/11/razer-huntsman-v3-pro-tkl.jpg" },

                // --- Tai nghe ---
                new SanPham { Id = 36, TenSanPham = "Tai nghe HyperX Cloud III Wireless", Gia = 3990000, HinhAnh = "https://media.kingston.com/hyperx/product/hx-product-headset-cloud-iii-wireless-black-1-zm-lg.jpg" },
                new SanPham { Id = 37, TenSanPham = "Tai nghe Logitech G733 Lightspeed", Gia = 3200000, HinhAnh = "https://resource.logitech.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/logitech/en/products/gaming-headsets/g733/gallery/g733-lightspeed-gallery-1-black.png" },

                // --- RAM / Nguồn / Tản nhiệt ---
                new SanPham { Id = 38, TenSanPham = "RAM Corsair Dominator Titanium 32GB 6000MHz", Gia = 5200000, HinhAnh = "https://www.corsair.com/medias/sys_master/images/images/h0e/h24/9467887575070/CMP32GX5M2B6000C30-Gallery-Dominator-Titanium-DDR5-RGB-Black-01.png" },
                new SanPham { Id = 39, TenSanPham = "Nguồn Seasonic Focus GX-850 850W Gold", Gia = 3800000, HinhAnh = "https://seasonic.com/uploads/products/FOCUS-GX-850_01.png" },
                new SanPham { Id = 40, TenSanPham = "Tản nhiệt nước NZXT Kraken Elite 360 RGB", Gia = 7500000, HinhAnh = "https://nzxt.com/assets/cms/34299/1662485331-kraken-elite-rgb-360-black-pdp-main-1.png" }
            );

            // Seed data cho user: Admin và User demo
            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung 
                { 
                    Id = 1, 
                    TenDangNhap = "admin", 
                    Email = "admin@thinhpc.com", 
                    MatKhau = "admin123", // Trong thực tế phải mã hóa
                    VaiTro = "Admin",
                    NgayTao = DateTime.Now,
                    DaKichHoat = true
                },
                new NguoiDung 
                { 
                    Id = 2, 
                    TenDangNhap = "user1", 
                    Email = "user1@gmail.com", 
                    MatKhau = "user123",
                    VaiTro = "User",
                    NgayTao = DateTime.Now,
                    DaKichHoat = true
                }
            );

            // Seed demo orders for testing Admin Dashboard / user history
            modelBuilder.Entity<DonHang>().HasData(
                new DonHang { Id = 1, UserId = 2, NgayDat = DateTime.Now.AddDays(-2), TongTien = 55000000 + 2990000, TrangThai = "HoanThanh" },
                new DonHang { Id = 2, UserId = 2, NgayDat = DateTime.Now.AddDays(-1), TongTien = 25000000, TrangThai = "DangGiao" }
            );

            modelBuilder.Entity<ChiTietDonHang>().HasData(
                new ChiTietDonHang { Id = 1, DonHangId = 1, SanPhamId = 1, SoLuong = 1, GiaTaiThoiDiemDat = 55000000m },
                new ChiTietDonHang { Id = 2, DonHangId = 1, SanPhamId = 10, SoLuong = 1, GiaTaiThoiDiemDat = 2990000m },
                new ChiTietDonHang { Id = 3, DonHangId = 2, SanPhamId = 4, SoLuong = 1, GiaTaiThoiDiemDat = 25000000m }
            );
        }
    }
}