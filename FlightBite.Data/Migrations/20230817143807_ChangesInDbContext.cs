using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "status", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2099), "In Progress", new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(1974), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(1980), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2119) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "status", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7762), "Is Processing", new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7632), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7779), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7782) });
        }
    }
}
