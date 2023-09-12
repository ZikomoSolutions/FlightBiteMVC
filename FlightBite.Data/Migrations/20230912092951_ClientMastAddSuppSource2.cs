using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClientMastAddSuppSource2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 59, 51, 844, DateTimeKind.Local).AddTicks(9165));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 14, 56, 44, 358, DateTimeKind.Local).AddTicks(6205));
        }
    }
}
