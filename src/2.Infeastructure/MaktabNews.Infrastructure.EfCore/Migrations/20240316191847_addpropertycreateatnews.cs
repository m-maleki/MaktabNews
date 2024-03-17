using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabNews.Infrastructure.EfCore.Migrations
{
    public partial class addpropertycreateatnews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 16, 22, 48, 47, 208, DateTimeKind.Local).AddTicks(3566));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 16, 0, 9, 3, 940, DateTimeKind.Local).AddTicks(7686));
        }
    }
}
