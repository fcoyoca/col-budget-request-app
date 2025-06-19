using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class removepastfundings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PastFunding",
                schema: "capitalEquipment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PastFunding",
                schema: "capitalEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapitalEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingSource = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FundingSubSource = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentId",
                        column: x => x.CapitalEquipmentId,
                        principalSchema: "capitalEquipment",
                        principalTable: "CapitalEquipments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PastFunding_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentId");
        }
    }
}
