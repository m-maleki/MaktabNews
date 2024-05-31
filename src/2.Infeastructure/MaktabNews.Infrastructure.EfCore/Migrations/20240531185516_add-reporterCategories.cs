using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabNews.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class addreporterCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryReporter",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ReportersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryReporter", x => new { x.CategoriesId, x.ReportersId });
                    table.ForeignKey(
                        name: "FK_CategoryReporter_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryReporter_Reporters_ReportersId",
                        column: x => x.ReportersId,
                        principalTable: "Reporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c1b1fd6-e8f0-43d1-9619-a176402d611d", "AQAAAAIAAYagAAAAEF5KwtUWZxfMOpEdN3JzbJOjFru40XLp1U2LO2D/Jf4p1jxrSxJvIT4OksHvG3XkUA==", "cda4a1ac-f029-463f-afd4-6a175d28c018" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0029e86-b01a-415d-9e72-c1fde0dcb080", "AQAAAAIAAYagAAAAEE2aUydywml7EZ3zni4Ke9s9EgXKpD0dMr6zQU7ByiWoEAGez0HjO+PHNysRaw8tKg==", "cb049d3e-2cae-4d63-9a7a-b683e72e4e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4bb81b8-4a3a-467b-b971-e127a3794c2b", "AQAAAAIAAYagAAAAEGqBhioBpqdwBOt9QjC/Hwj2SZpaSHuaE6V7oLGjgO98DRObOZTqau/ux7RJW3/o3Q==", "4ebcdf5f-f413-4041-a0da-d4bace46ee8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "132bdcb3-152c-4b3a-8d0d-95fc3bd19b0e", "AQAAAAIAAYagAAAAEIdVyfmSZonjDlJjduPs7TlefO2VQWX7POmVX1MlH0s7u2K7tBs1UTIQ6eHdlFtlfw==", "0c2d9129-be46-42b1-99b7-02f7828ae1d6" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 5, 31, 22, 25, 15, 589, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.CreateIndex(
                name: "IX_CategoryReporter_ReportersId",
                table: "CategoryReporter",
                column: "ReportersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryReporter");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8a64b31-c8f5-4172-b91b-a779385fe30d", "AQAAAAIAAYagAAAAEB3fhZvVpQc7KDBnLkaJMYQNXaSr63FXcUhElEg8hbJNEOy8nhRCRZmfZ0xJQMo56A==", "ebc128c2-feab-414d-bd5a-8153b20c35c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13a949e9-c664-4986-8483-0ceea5f8fa4f", "AQAAAAIAAYagAAAAEHb0pyy5wRQyfhPuP8bKoCz/ae3YyQOhR+BCBmfdzUhUvWAzamBGZeGepbKydQSURg==", "bc206d5f-5bca-4de5-8584-7f7642c9c647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72b58c3a-7da4-4cbf-8265-43c8b48dfb3b", "AQAAAAIAAYagAAAAEMotqZ9LteXCZKMWe6Ce01hBpj0qQrUNonwmjcsL4PjkS7fqYhHCHzw2Me/gBUqwkg==", "96a3eaea-17c2-47a1-a8b1-7119171ba74b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4a93711-08f7-4361-ba8f-0468eaac2b76", "AQAAAAIAAYagAAAAEFdXlRPOJjRudaL7dPVPsehQN2GRQo4SkBesMKUS7OruFdnIhLj67ebFGwmAlev62g==", "941c2181-351c-4f72-a9af-1cbf152a5cc7" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 5, 22, 23, 17, 3, 25, DateTimeKind.Local).AddTicks(8993));
        }
    }
}
