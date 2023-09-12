using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSuppSourceT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientMasters_SupplierSourceModel_SupplierSourceModelId",
                table: "ClientMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierSourceModel",
                table: "SupplierSourceModel");

            migrationBuilder.RenameTable(
                name: "SupplierSourceModel",
                newName: "SupplierSources");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierSources",
                table: "SupplierSources",
                column: "id");

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
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "SupplierSources",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 12, 15, 42, 41, 165, DateTimeKind.Local).AddTicks(5592));

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

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMasters_SupplierSources_SupplierSourceModelId",
                table: "ClientMasters",
                column: "SupplierSourceModelId",
                principalTable: "SupplierSources",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientMasters_SupplierSources_SupplierSourceModelId",
                table: "ClientMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierSources",
                table: "SupplierSources");

            migrationBuilder.RenameTable(
                name: "SupplierSources",
                newName: "SupplierSourceModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierSourceModel",
                table: "SupplierSourceModel",
                column: "id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMasters_SupplierSourceModel_SupplierSourceModelId",
                table: "ClientMasters",
                column: "SupplierSourceModelId",
                principalTable: "SupplierSourceModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
