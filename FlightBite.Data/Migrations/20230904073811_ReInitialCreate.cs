using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    EnquiryPlatformModelId = table.Column<int>(type: "int", nullable: false),
                    EnquiryStatusModelId = table.Column<int>(type: "int", nullable: false),
                    UserTypesModelId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnquiryMaster_EnquityPlatform_EnquiryPlatformModelId",
                        column: x => x.EnquiryPlatformModelId,
                        principalTable: "EnquityPlatform",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnquiryMaster_UserType_UserTypesModelId",
                        column: x => x.UserTypesModelId,
                        principalTable: "UserType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnquiryNoteDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    note = table.Column<string>(type: "nvarchar(Max)", nullable: true),
                    EnquiryMasterModelId = table.Column<int>(type: "int", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquiryNoteDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_EnquiryNoteDetail_EnquiryMaster_EnquiryMasterModelId",
                        column: x => x.EnquiryMasterModelId,
                        principalTable: "EnquiryMaster",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "EnquiryStatus",
                columns: new[] { "id", "created_at", "deleted_at", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3083), null, "In Progress", null },
                    { 2, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3086), null, "Complete", null }
                });

            migrationBuilder.InsertData(
                table: "EnquityPlatform",
                columns: new[] { "id", "created_at", "deleted_at", "description", "plat_form", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(2950), null, "-", "Google", null },
                    { 2, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(2954), null, "-", "Brochure", null },
                    { 3, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(2958), null, "-", "Other", null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "created_at", "deleted_at", "description", "updated_at", "user_type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3102), null, "-", null, "Supplier" },
                    { 2, new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3104), null, "-", null, "Travel Agent" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryMaster_EnquiryPlatformModelId",
                table: "EnquiryMaster",
                column: "EnquiryPlatformModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryMaster_EnquiryStatusModelId",
                table: "EnquiryMaster",
                column: "EnquiryStatusModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryMaster_UserTypesModelId",
                table: "EnquiryMaster",
                column: "UserTypesModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryNoteDetail_EnquiryMasterModelId",
                table: "EnquiryNoteDetail",
                column: "EnquiryMasterModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnquiryNoteDetail");

            migrationBuilder.DropTable(
                name: "LogsMaster");

            migrationBuilder.DropTable(
                name: "RequestLogsMasters");

            migrationBuilder.DropTable(
                name: "RequestResponseLogs");

            migrationBuilder.DropTable(
                name: "EnquiryMaster");

            migrationBuilder.DropTable(
                name: "EnquiryStatus");

            migrationBuilder.DropTable(
                name: "EnquityPlatform");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
