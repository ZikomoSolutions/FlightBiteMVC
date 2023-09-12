using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClientMastAddSuppSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "ClientTerms");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "ClientTerms");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "ClientTerms");

            migrationBuilder.AddColumn<int>(
                name: "SupplierSourceModelId",
                table: "ClientMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_ClientMasters_SupplierSourceModelId",
                table: "ClientMasters",
                column: "SupplierSourceModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMasters_SupplierSourceModel_SupplierSourceModelId",
                table: "ClientMasters",
                column: "SupplierSourceModelId",
                principalTable: "SupplierSourceModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientMasters_SupplierSourceModel_SupplierSourceModelId",
                table: "ClientMasters");

            migrationBuilder.DropIndex(
                name: "IX_ClientMasters_SupplierSourceModelId",
                table: "ClientMasters");

            migrationBuilder.DropColumn(
                name: "SupplierSourceModelId",
                table: "ClientMasters");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "ClientTerms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "ClientTerms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "ClientTerms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "SupplierSourceModel",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "TermMasters",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 12, 26, 27, 589, DateTimeKind.Local).AddTicks(4673));
        }
    }
}
