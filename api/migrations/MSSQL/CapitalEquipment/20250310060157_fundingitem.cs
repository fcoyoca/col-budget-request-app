using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class fundingitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FundingItem",
                schema: "capitalEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundingSource = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GrantingAgency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentYearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundingItem_CapitalEquipments_CapitalEquipmentId",
                        column: x => x.CapitalEquipmentId,
                        principalSchema: "capitalEquipment",
                        principalTable: "CapitalEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FundingYearItem",
                schema: "capitalEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FundingItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingYearItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundingYearItem_FundingItem_FundingItemId",
                        column: x => x.FundingItemId,
                        principalSchema: "capitalEquipment",
                        principalTable: "FundingItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FundingItem_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "FundingItem",
                column: "CapitalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingItem_CurrentYearRequestedId",
                schema: "capitalEquipment",
                table: "FundingItem",
                column: "CurrentYearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_FundingItemId",
                schema: "capitalEquipment",
                table: "FundingYearItem",
                column: "FundingItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingItem_FundingYearItem_CurrentYearRequestedId",
                schema: "capitalEquipment",
                table: "FundingItem",
                column: "CurrentYearRequestedId",
                principalSchema: "capitalEquipment",
                principalTable: "FundingYearItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FundingItem_FundingYearItem_CurrentYearRequestedId",
                schema: "capitalEquipment",
                table: "FundingItem");

            migrationBuilder.DropTable(
                name: "FundingYearItem",
                schema: "capitalEquipment");

            migrationBuilder.DropTable(
                name: "FundingItem",
                schema: "capitalEquipment");
        }
    }
}
