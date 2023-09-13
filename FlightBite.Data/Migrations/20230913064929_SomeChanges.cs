using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class SomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "SupplierSources",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "source_name" },
                values: new object[] { new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6848), "NotInUsed" });

            migrationBuilder.UpdateData(
                table: "SupplierSources",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "source_name" },
                values: new object[] { new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6850), "API" });

            migrationBuilder.InsertData(
                table: "SupplierSources",
                columns: new[] { "id", "created_at", "deleted_at", "source_name", "updated_at" },
                values: new object[] { 3, new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6852), null, "WEB", null });

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 13, 12, 19, 29, 541, DateTimeKind.Local).AddTicks(6784));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SupplierSources",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "SupplierSources",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "source_name" },
                values: new object[] { new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5590), "API" });

            migrationBuilder.UpdateData(
                table: "SupplierSources",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "source_name" },
                values: new object[] { new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5592), "WEB" });

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5561));
        }
    }
}
