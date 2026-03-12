using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class KhoMoiKeng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "Gia", "TenSanPham" },
                values: new object[,]
                {
                    { 1, 55000000, "VGA ASUS ROG Strix 4090" },
                    { 2, 15000000, "CPU Intel Core i9-14900K" },
                    { 3, 6500000, "RAM G.Skill Trident Z5 RGB 64GB" },
                    { 4, 25000000, "Mainboard MSI Z790 Godlike" },
                    { 5, 4500000, "SSD Samsung 990 Pro 2TB" },
                    { 6, 4200000, "Nguồn Corsair RM1000x" },
                    { 7, 4000000, "Case NZXT H9 Flow" },
                    { 8, 32000000, "Màn hình Samsung Odyssey G9" },
                    { 9, 3990000, "Chuột Razer Viper V3 Pro" },
                    { 10, 2990000, "Phím cơ Akko MOD007" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPhams");
        }
    }
}
