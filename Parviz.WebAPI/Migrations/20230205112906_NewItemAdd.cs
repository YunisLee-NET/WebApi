using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parviz.WebAPI.Migrations
{
    public partial class NewItemAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2023, 2, 2, 15, 29, 5, 241, DateTimeKind.Local).AddTicks(4429), "https://amazoncomp.az/wp-content/uploads/2021/02/879e1188ce55477baa8a6111c7a9e4bb.jpg", "Lenovo Ideapad", 1600m, 15 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2023, 2, 3, 15, 29, 5, 241, DateTimeKind.Local).AddTicks(8546), "https://kontakt.az/wp-content/uploads/gallery-tum/TM-DG-SBP-1105-SM-1849_25d3acf64c924d9482b1916e696cad69_w_png.webp", "Xiaomi 12", 1100m, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2023, 1, 31, 15, 29, 5, 241, DateTimeKind.Local).AddTicks(8565), "https://kontakt.az/wp-content/uploads/2021/08/New-Project-48.jpg", "Sony PlayStation 5", 1800m, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
