using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabNews.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class editentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Reporters_ReporterId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Visitors_VisitorId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_News_NewsId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NewsId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VisitorId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReporterId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ReporterId" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2093), 3 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "ReporterId" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2100), 3 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "ReporterId" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 23, 31, 887, DateTimeKind.Local).AddTicks(2104), 3 });

            migrationBuilder.UpdateData(
                table: "Reporters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reporters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Address",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reporters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: null);

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AboutMe", "Address" },
                values: new object[] { null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Reporters_ReporterId",
                table: "AspNetUsers",
                column: "ReporterId",
                principalTable: "Reporters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Visitors_VisitorId",
                table: "AspNetUsers",
                column: "VisitorId",
                principalTable: "Visitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_News_NewsId",
                table: "Comments",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Reporters_ReporterId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Visitors_VisitorId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_News_NewsId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Reporters");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NewsId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VisitorId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReporterId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ReporterId" },
                values: new object[] { new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3120), 2 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "ReporterId" },
                values: new object[] { new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3128), 2 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "ReporterId" },
                values: new object[] { new DateTime(2024, 5, 17, 11, 5, 42, 736, DateTimeKind.Local).AddTicks(3132), 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Reporters_ReporterId",
                table: "AspNetUsers",
                column: "ReporterId",
                principalTable: "Reporters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Visitors_VisitorId",
                table: "AspNetUsers",
                column: "VisitorId",
                principalTable: "Visitors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_News_NewsId",
                table: "Comments",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id");
        }
    }
}
