using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace yy.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(521), "System", "Black" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(525), "System", "Blue" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(992), "System", "BMW" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(996), "System", "Toyota" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1277), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1279), "System", "3 Series" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1281), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1282), "System", "X5" },
                    { 3, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1283), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1284), "System", "Prius" },
                    { 4, "System", new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 11, 24, 11, 2, 22, 920, DateTimeKind.Local).AddTicks(1286), "System", "Rav4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
