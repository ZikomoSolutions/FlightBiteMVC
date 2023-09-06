using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightBite.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateClientTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientMasters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    contact_person = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    vat_number = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    registeration_no = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    account_holder = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    job_title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    contact_email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ATOL = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IATA = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PTS = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TTA = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_phone = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    logo_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTypesModelId = table.Column<int>(type: "int", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMasters", x => x.id);
                    table.ForeignKey(
                        name: "FK_ClientMasters_UserType_UserTypesModelId",
                        column: x => x.UserTypesModelId,
                        principalTable: "UserType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierSourceModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    source_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSourceModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TermMasters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermMasters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTerms",
                columns: table => new
                {
                    ClientMasterModelId = table.Column<int>(type: "int", nullable: false),
                    TermMasterModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTerms", x => new { x.ClientMasterModelId, x.TermMasterModelId });
                    table.ForeignKey(
                        name: "FK_ClientTerms_ClientMasters_ClientMasterModelId",
                        column: x => x.ClientMasterModelId,
                        principalTable: "ClientMasters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTerms_TermMasters_TermMasterModelId",
                        column: x => x.TermMasterModelId,
                        principalTable: "TermMasters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.InsertData(
                table: "SupplierSourceModel",
                columns: new[] { "id", "created_at", "deleted_at", "source_name", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 6, 12, 4, 46, 645, DateTimeKind.Local).AddTicks(2347), null, "API", null },
                    { 2, new DateTime(2023, 9, 6, 12, 4, 46, 645, DateTimeKind.Local).AddTicks(2350), null, "WEB", null }
                });

            migrationBuilder.InsertData(
                table: "TermMasters",
                columns: new[] { "id", "created_at", "deleted_at", "terms", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8571), null, "FlightBite Agreement Signed", null },
                    { 2, new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8573), null, "Required Documents Added and Signed Off", null }
                });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 6, 12, 4, 46, 644, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.CreateIndex(
                name: "IX_ClientMasters_UserTypesModelId",
                table: "ClientMasters",
                column: "UserTypesModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTerms_TermMasterModelId",
                table: "ClientTerms",
                column: "TermMasterModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTerms");

            migrationBuilder.DropTable(
                name: "SupplierSourceModel");

            migrationBuilder.DropTable(
                name: "ClientMasters");

            migrationBuilder.DropTable(
                name: "TermMasters");

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "EnquiryStatus",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "EnquityPlatform",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2023, 9, 4, 13, 8, 11, 492, DateTimeKind.Local).AddTicks(3104));
        }
    }
}
