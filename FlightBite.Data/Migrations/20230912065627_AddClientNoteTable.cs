using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddClientNoteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ClientNoteDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    note = table.Column<string>(type: "nvarchar(Max)", nullable: true),
                    ClientMasterModelId = table.Column<int>(type: "int", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNoteDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_ClientNoteDetails_ClientMasters_ClientMasterModelId",
                        column: x => x.ClientMasterModelId,
                        principalTable: "ClientMasters",
                        principalColumn: "id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ClientNoteDetails_ClientMasterModelId",
                table: "ClientNoteDetails",
                column: "ClientMasterModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientNoteDetails");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "ClientTerms");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "ClientTerms");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "ClientTerms");

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
    }
}
