using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class pastfunding_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PastFunding",
                schema: "capitalEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingSource = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FundingSubSource = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SOF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapitalEquipmentItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentItemId",
                        column: x => x.CapitalEquipmentItemId,
                        principalSchema: "capitalEquipment",
                        principalTable: "CapitalEquipments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PastFunding_CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PastFunding",
                schema: "capitalEquipment");
        }
    }
}
