using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeConnectionStringName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 8, 17, 18, 28, 31, 802, DateTimeKind.Local).AddTicks(7763) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3387), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3387) });

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

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3405), new DateTime(2023, 8, 17, 13, 46, 39, 570, DateTimeKind.Local).AddTicks(3406) });
        }
    }
}
