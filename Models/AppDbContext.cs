using System;
using Microsoft.EntityFrameworkCore;

namespace Buoi1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<XeMay> SanPhams { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<HangXe> HangXes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<XeMay>(eb =>
            {
                eb.Property(x => x.Gia).HasColumnType("decimal(18,0)");
                eb.Property(x => x.MaHangXe).HasDefaultValue(1);
                eb.Property(x => x.PhanKhoi).HasDefaultValue(0);
                eb.Property(x => x.MauSac).HasDefaultValue("N/A");
                eb.Property(x => x.NamSanXuat).HasDefaultValue(2023);
                eb.Property(x => x.SoLuongTon).HasDefaultValue(0);
            });

            modelBuilder.Entity<DonHang>(eb =>
            {
                eb.Property(x => x.TongTien).HasColumnType("decimal(18,0)");
            });

            modelBuilder.Entity<ChiTietDonHang>(eb =>
            {
                eb.Property(x => x.GiaTaiThoiDiemDat).HasColumnType("decimal(18,0)");
            });

            modelBuilder.Entity<HangXe>()
                .HasMany(h => h.XeMays)
                .WithOne(x => x.HangXe)
                .HasForeignKey(x => x.MaHangXe)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HangXe>().HasData(
                new HangXe { Id = 1, TenHang = "Honda" },
                new HangXe { Id = 2, TenHang = "Yamaha" },
                new HangXe { Id = 3, TenHang = "Suzuki" }
            );

            modelBuilder.Entity<XeMay>().HasData(
     new XeMay { Id = 1, TenSanPham = "Honda Wave Alpha 110", Gia = 18900000, HinhAnh = "https://placehold.co/400x300?text=Honda+Wave+Alpha", MaHangXe = 1, PhanKhoi = 110, MauSac = "Do", NamSanXuat = 2024, SoLuongTon = 10 },
     new XeMay { Id = 2, TenSanPham = "Honda Air Blade 125", Gia = 38900000, HinhAnh = "https://placehold.co/400x300?text=Honda+Air+Blade", MaHangXe = 1, PhanKhoi = 125, MauSac = "Den", NamSanXuat = 2024, SoLuongTon = 8 },
     new XeMay { Id = 3, TenSanPham = "Honda Vision 110", Gia = 30900000, HinhAnh = "https://placehold.co/400x300?text=Honda+Vision", MaHangXe = 1, PhanKhoi = 110, MauSac = "Do", NamSanXuat = 2024, SoLuongTon = 15 },
     new XeMay { Id = 4, TenSanPham = "Honda SH 150i", Gia = 70900000, HinhAnh = "https://placehold.co/400x300?text=Honda+SH+150i", MaHangXe = 1, PhanKhoi = 150, MauSac = "Trang", NamSanXuat = 2024, SoLuongTon = 5 },
     new XeMay { Id = 5, TenSanPham = "Honda PCX 125", Gia = 52900000, HinhAnh = "https://placehold.co/400x300?text=Honda+PCX+125", MaHangXe = 1, PhanKhoi = 125, MauSac = "Den", NamSanXuat = 2024, SoLuongTon = 7 },
     new XeMay { Id = 6, TenSanPham = "Honda CB150R", Gia = 68000000, HinhAnh = "https://placehold.co/400x300?text=Honda+CB150R", MaHangXe = 1, PhanKhoi = 150, MauSac = "Den", NamSanXuat = 2023, SoLuongTon = 4 },
     new XeMay { Id = 7, TenSanPham = "Honda Winner X 150", Gia = 46900000, HinhAnh = "https://placehold.co/400x300?text=Honda+Winner+X", MaHangXe = 1, PhanKhoi = 150, MauSac = "Trang", NamSanXuat = 2024, SoLuongTon = 6 },
     new XeMay { Id = 8, TenSanPham = "Yamaha Exciter 155 VVA", Gia = 52990000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+Exciter+155", MaHangXe = 2, PhanKhoi = 155, MauSac = "Xanh", NamSanXuat = 2024, SoLuongTon = 9 },
     new XeMay { Id = 9, TenSanPham = "Yamaha NVX 155 VVA", Gia = 53990000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+NVX+155", MaHangXe = 2, PhanKhoi = 155, MauSac = "Den", NamSanXuat = 2024, SoLuongTon = 7 },
     new XeMay { Id = 10, TenSanPham = "Yamaha Grande 125 Hybrid", Gia = 48990000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+Grande+125", MaHangXe = 2, PhanKhoi = 125, MauSac = "Trang", NamSanXuat = 2024, SoLuongTon = 8 },
     new XeMay { Id = 11, TenSanPham = "Yamaha Janus 125", Gia = 31490000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+Janus+125", MaHangXe = 2, PhanKhoi = 125, MauSac = "Hong", NamSanXuat = 2023, SoLuongTon = 12 },
     new XeMay { Id = 12, TenSanPham = "Yamaha Freego 125", Gia = 38990000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+Freego+125", MaHangXe = 2, PhanKhoi = 125, MauSac = "Xanh", NamSanXuat = 2023, SoLuongTon = 6 },
     new XeMay { Id = 13, TenSanPham = "Yamaha R15 V4", Gia = 98000000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+R15+V4", MaHangXe = 2, PhanKhoi = 155, MauSac = "Xanh", NamSanXuat = 2024, SoLuongTon = 3 },
     new XeMay { Id = 14, TenSanPham = "Yamaha MT-15 V2", Gia = 94000000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+MT-15+V2", MaHangXe = 2, PhanKhoi = 155, MauSac = "Den", NamSanXuat = 2024, SoLuongTon = 4 },
     new XeMay { Id = 15, TenSanPham = "Suzuki Raider R150 Fi", Gia = 52990000, HinhAnh = "https://placehold.co/400x300?text=Suzuki+Raider+R150", MaHangXe = 3, PhanKhoi = 150, MauSac = "Trang", NamSanXuat = 2023, SoLuongTon = 5 },
     new XeMay { Id = 16, TenSanPham = "Suzuki Hayate 125", Gia = 28500000, HinhAnh = "https://placehold.co/400x300?text=Suzuki+Hayate+125", MaHangXe = 3, PhanKhoi = 125, MauSac = "Xam", NamSanXuat = 2023, SoLuongTon = 8 },
     new XeMay { Id = 17, TenSanPham = "Suzuki Address 110", Gia = 21990000, HinhAnh = "https://placehold.co/400x300?text=Suzuki+Address+110", MaHangXe = 3, PhanKhoi = 110, MauSac = "Trang", NamSanXuat = 2023, SoLuongTon = 10 },
     new XeMay { Id = 18, TenSanPham = "Suzuki GSX-R150", Gia = 79000000, HinhAnh = "https://placehold.co/400x300?text=Suzuki+GSX-R150", MaHangXe = 3, PhanKhoi = 150, MauSac = "Xanh", NamSanXuat = 2023, SoLuongTon = 3 },
     new XeMay { Id = 19, TenSanPham = "Honda Lead 125", Gia = 37900000, HinhAnh = "https://placehold.co/400x300?text=Honda+Lead+125", MaHangXe = 1, PhanKhoi = 125, MauSac = "Do", NamSanXuat = 2024, SoLuongTon = 9 },
     new XeMay { Id = 20, TenSanPham = "Yamaha Sirius 115 Fi", Gia = 21490000, HinhAnh = "https://placehold.co/400x300?text=Yamaha+Sirius+115", MaHangXe = 2, PhanKhoi = 115, MauSac = "Den", NamSanXuat = 2023, SoLuongTon = 14 }
 );

            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung
                {
                    Id = 1,
                    TenDangNhap = "admin",
                    Email = "admin@xemaystore.com",
                    MatKhau = "admin123",
                    VaiTro = "Admin",
                    NgayTao = new DateTime(2024, 1, 1),
                    DaKichHoat = true
                },
                new NguoiDung
                {
                    Id = 2,
                    TenDangNhap = "user1",
                    Email = "user1@gmail.com",
                    MatKhau = "user123",
                    VaiTro = "User",
                    NgayTao = new DateTime(2024, 1, 1),
                    DaKichHoat = true
                }
            );

            modelBuilder.Entity<DonHang>().HasData(
                new DonHang { Id = 1, UserId = 2, NgayDat = new DateTime(2024, 1, 10), TongTien = 38900000, TrangThai = "HoanThanh" },
                new DonHang { Id = 2, UserId = 2, NgayDat = new DateTime(2024, 1, 11), TongTien = 52990000, TrangThai = "DangGiao" }
            );

            modelBuilder.Entity<ChiTietDonHang>().HasData(
                new ChiTietDonHang { Id = 1, DonHangId = 1, SanPhamId = 2, SoLuong = 1, GiaTaiThoiDiemDat = 38900000m },
                new ChiTietDonHang { Id = 2, DonHangId = 2, SanPhamId = 8, SoLuong = 1, GiaTaiThoiDiemDat = 52990000m }
            );
        }
    }
}