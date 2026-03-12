using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class AddDonHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonHangId = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTaiThoiDiemDat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_DonHangs_DonHangId",
                        column: x => x.DonHangId,
                        principalTable: "DonHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_SanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "NgayDat", "TongTien", "TrangThai", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 10, 16, 13, 14, 213, DateTimeKind.Local).AddTicks(1406), 57990000m, "HoanThanh", 2 },
                    { 2, new DateTime(2026, 3, 11, 16, 13, 14, 213, DateTimeKind.Local).AddTicks(1419), 25000000m, "DangGiao", 2 }
                });

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

            migrationBuilder.InsertData(
                table: "ChiTietDonHangs",
                columns: new[] { "Id", "DonHangId", "GiaTaiThoiDiemDat", "SanPhamId", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1, 55000000m, 1, 1 },
                    { 2, 1, 2990000m, 10, 1 },
                    { 3, 2, 25000000m, 4, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_DonHangId",
                table: "ChiTietDonHangs",
                column: "DonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_SanPhamId",
                table: "ChiTietDonHangs",
                column: "SanPhamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2026, 3, 12, 13, 45, 36, 708, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2026, 3, 12, 13, 45, 36, 708, DateTimeKind.Local).AddTicks(2444));
        }
    }
}
