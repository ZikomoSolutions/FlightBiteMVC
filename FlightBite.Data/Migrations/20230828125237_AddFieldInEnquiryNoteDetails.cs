using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldInEnquiryNoteDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnquiryId",
                table: "EnquiryNoteDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "type" },
                values: new object[] { new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2204), "Supplier" });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 8, 28, 18, 22, 37, 811, DateTimeKind.Local).AddTicks(2206));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnquiryId",
                table: "EnquiryNoteDetail");

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "type" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4292), "Flight Provider / Consolidator" });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4294));
        }
    }
}
