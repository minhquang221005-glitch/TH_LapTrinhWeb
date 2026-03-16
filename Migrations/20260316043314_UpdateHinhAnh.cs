using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buoi1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHinhAnh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+Wave+Alpha");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+Air+Blade");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+Vision");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+SH+150i");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+PCX+125");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 6,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+CB150R");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 7,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+Winner+X");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 8,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+Exciter+155");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 9,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+NVX+155");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 10,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+Grande+125");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 11,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+Janus+125");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 12,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+Freego+125");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 13,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+R15+V4");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 14,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+MT-15+V2");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 15,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Suzuki+Raider+R150");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 16,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Suzuki+Hayate+125");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 17,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Suzuki+Address+110");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 18,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Suzuki+GSX-R150");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 19,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Honda+Lead+125");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 20,
                column: "HinhAnh",
                value: "https://placehold.co/400x300?text=Yamaha+Sirius+115");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 1,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/wave-alpha/wave-alpha-do-den.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 2,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/air-blade/air-blade-125-special-den-do.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 3,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/vision/vision-do-den.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 4,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/sh150i/sh150i-trang.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 5,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/pcx/pcx125-den.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 6,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/cb150r/cb150r-den.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 7,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/winner-x/winner-x-trang-do.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 8,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/exciter-155-vva.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 9,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/nvx155-vva.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 10,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/grande-125-hybrid.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 11,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/janus-125.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 12,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/freego-125.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 13,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/r15-v4.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 14,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/mt15-v2.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 15,
                column: "HinhAnh",
                value: "https://suzuki.com.vn/wp-content/uploads/2021/06/raider-r150.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 16,
                column: "HinhAnh",
                value: "https://suzuki.com.vn/wp-content/uploads/2021/06/hayate-125.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 17,
                column: "HinhAnh",
                value: "https://suzuki.com.vn/wp-content/uploads/2021/06/address-110.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 18,
                column: "HinhAnh",
                value: "https://suzuki.com.vn/wp-content/uploads/2021/06/gsx-r150.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 19,
                column: "HinhAnh",
                value: "https://www.honda.com.vn/uploads/products/lead/lead-125-do-den.png");

            migrationBuilder.UpdateData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: 20,
                column: "HinhAnh",
                value: "https://yamaha-motor.com.vn/wp-content/uploads/2022/09/sirius-115-fi.png");
        }
    }
}
