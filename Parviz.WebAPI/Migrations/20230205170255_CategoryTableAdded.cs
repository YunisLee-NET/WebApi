using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parviz.WebAPI.Migrations
{
    public partial class CategoryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedTime", "ImagePath", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Notbuk", new DateTime(2023, 2, 5, 21, 2, 55, 220, DateTimeKind.Local).AddTicks(3446), null, 0m, 0 },
                    { 2, "Telefon", new DateTime(2023, 2, 5, 21, 2, 55, 221, DateTimeKind.Local).AddTicks(4104), null, 0m, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 2, 21, 2, 55, 231, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 3, 21, 2, 55, 231, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 31, 21, 2, 55, 231, DateTimeKind.Local).AddTicks(3580));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 2, 20, 58, 47, 756, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 3, 20, 58, 47, 756, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 31, 20, 58, 47, 756, DateTimeKind.Local).AddTicks(2181));
        }
    }
}
