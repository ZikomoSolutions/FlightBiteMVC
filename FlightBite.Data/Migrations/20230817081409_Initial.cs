using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnquiryMaster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    contact_person = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    ATOL = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IATA = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    job_title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    contact_email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    contact_phone = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    enquiry_platform_id = table.Column<int>(type: "int", nullable: false),
                    enquiry_status_id = table.Column<int>(type: "int", nullable: false),
                    user_type_id = table.Column<int>(type: "int", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquiryMaster", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EnquiryNoteDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enquiry_id = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquiryNoteDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EnquiryStatus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquiryStatus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EnquityPlatform",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquityPlatform", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "EnquiryStatus",
                columns: new[] { "id", "created_at", "deleted_at", "status", "updated_at" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8369), null, "Is Processing", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8370) },
                    { 5, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8372), null, "Complete", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8372) }
                });

            migrationBuilder.InsertData(
                table: "EnquityPlatform",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8249), null, "-", "Google", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8251) },
                    { 2, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8256), null, "-", "Brochure", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8257) },
                    { 3, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8259), null, "-", "Other", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8259) }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "created_at", "deleted_at", "description", "type", "updated_at" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8383), null, "-", "Supplier", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8384) },
                    { 7, new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8385), null, "-", "Agent", new DateTime(2023, 8, 17, 13, 44, 9, 240, DateTimeKind.Local).AddTicks(8386) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnquiryMaster");

            migrationBuilder.DropTable(
                name: "EnquiryNoteDetail");

            migrationBuilder.DropTable(
                name: "EnquiryStatus");

            migrationBuilder.DropTable(
                name: "EnquityPlatform");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
