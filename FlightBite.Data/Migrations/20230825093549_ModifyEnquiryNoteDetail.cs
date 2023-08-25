using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyEnquiryNoteDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enquiry_id",
                table: "EnquiryNoteDetail");

            migrationBuilder.AlterColumn<string>(
                name: "note",
                table: "EnquiryNoteDetail",
                type: "nvarchar(Max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4276), null });

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4278), null });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4154), null });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4158), null });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4160), null });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "type", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4292), "Flight Provider / Consolidator", null });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "type", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 5, 49, 190, DateTimeKind.Local).AddTicks(4294), "Travel Agent", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "note",
                table: "EnquiryNoteDetail",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(Max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "enquiry_id",
                table: "EnquiryNoteDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4039), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4046), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "type", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4204), "Supplier", new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "type", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4207), "Agent", new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4208) });
        }
    }
}
