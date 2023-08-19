using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "EnquiryStatus",
                columns: new[] { "id", "created_at", "deleted_at", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3384), null, "Is Processing", new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3385) },
                    { 2, new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3387), null, "Complete", new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3387) }
                });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3251), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3258), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "created_at", "deleted_at", "description", "type", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3401), null, "-", "Supplier", new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3401) },
                    { 2, new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3405), null, "-", "Agent", new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3406) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "EnquiryStatus",
                columns: new[] { "id", "created_at", "deleted_at", "status", "updated_at" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8369), null, "Is Processing", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8370) },
                    { 5, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8372), null, "Complete", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8372) }
                });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8249), new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "created_at", "deleted_at", "description", "type", "updated_at" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8383), null, "-", "Supplier", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8384) },
                    { 7, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8385), null, "-", "Agent", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8386) }
                });
        }
    }
}
