using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnquiryNoteDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnquiryId = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(Max)", nullable: true),
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
                    plat_form = table.Column<string>(type: "nvarchar(50)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.id);
                });

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
                    EnquiryStatusModelId = table.Column<int>(type: "int", nullable: true),
                    user_type_id = table.Column<int>(type: "int", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquiryMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_EnquiryMaster_EnquiryStatus_EnquiryStatusModelId",
                        column: x => x.EnquiryStatusModelId,
                        principalTable: "EnquiryStatus",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "EnquiryStatus",
                columns: new[] { "id", "created_at", "deleted_at", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(428), null, "In Progress", null },
                    { 2, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(430), null, "Complete", null }
                });

            migrationBuilder.InsertData(
                table: "EnquityPlatform",
                columns: new[] { "id", "created_at", "deleted_at", "description", "plat_form", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(305), null, "-", "Google", null },
                    { 2, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(308), null, "-", "Brochure", null },
                    { 3, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(310), null, "-", "Other", null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "created_at", "deleted_at", "description", "updated_at", "user_type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(443), null, "-", null, "Supplier" },
                    { 2, new DateTime(2023, 8, 30, 18, 26, 18, 899, DateTimeKind.Local).AddTicks(445), null, "-", null, "Travel Agent" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryMaster_EnquiryStatusModelId",
                table: "EnquiryMaster",
                column: "EnquiryStatusModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnquiryMaster");

            migrationBuilder.DropTable(
                name: "EnquiryNoteDetail");

            migrationBuilder.DropTable(
                name: "EnquityPlatform");

            migrationBuilder.DropTable(
                name: "LogsMaster");

            migrationBuilder.DropTable(
                name: "RequestLogsMasters");

            migrationBuilder.DropTable(
                name: "RequestResponseLogs");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "EnquiryStatus");
        }
    }
}
