using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class BasicStructureChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 152, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 152, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6628));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 645, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 645, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8554));
        }
    }
}
