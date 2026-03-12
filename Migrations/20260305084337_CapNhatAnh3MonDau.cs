using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class CapNhatAnh3MonDau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                column: "HinhAnh",
                value: "https://cdn2.cellphones.com.vn/x/media/catalog/product/v/g/vga_35_.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                column: "HinhAnh",
                value: "https://kccshop.vn/media/product/28247_cpu_intel_core_i9_14900k.jpg");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                column: "HinhAnh",
                value: "https://memoryzone.com.vn/wp-content/uploads/2023/11/ram-pc-g-skill-trident-z5-rgb-64gb-32gbx2-ddr5-6400mhz-black-1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                column: "HinhAnh",
                value: null);

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                column: "HinhAnh",
                value: null);

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                column: "HinhAnh",
                value: null);
        }
    }
}
