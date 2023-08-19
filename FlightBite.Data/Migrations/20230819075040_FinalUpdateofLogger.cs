using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinalUpdateofLogger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogsMaster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    message = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    stack_track = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    file_name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    class_name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    method = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    line_number = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "DateTime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "DateTime", nullable: true),
                    client_api_address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsMaster", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RequestLogsMasters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    response = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    created_at = table.Column<DateTime>(type: "DateTime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "DateTime", nullable: true),
                    client_ip_address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLogsMasters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RequestResponseLogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    response = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    created_at = table.Column<DateTime>(type: "DateTime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "DateTime", nullable: true),
                    client_ip_address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestResponseLogs", x => x.id);
                });

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
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 8, 19, 13, 20, 39, 998, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryMaster_enquiry_status_id",
                table: "EnquiryMaster",
                column: "enquiry_status_id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnquiryMaster_EnquiryStatus_enquiry_status_id",
                table: "EnquiryMaster",
                column: "enquiry_status_id",
                principalTable: "EnquiryStatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnquiryMaster_EnquiryStatus_enquiry_status_id",
                table: "EnquiryMaster");

            migrationBuilder.DropTable(
                name: "LogsMaster");

            migrationBuilder.DropTable(
                name: "RequestLogsMasters");

            migrationBuilder.DropTable(
                name: "RequestResponseLogs");

            migrationBuilder.DropIndex(
                name: "IX_EnquiryMaster_enquiry_status_id",
                table: "EnquiryMaster");

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2099), new DateTime(2023, 8, 17, 20, 8, 7, 613, DateTimeKind.Local).AddTicks(2099) });

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
    }
}
