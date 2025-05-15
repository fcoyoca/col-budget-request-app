using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class pastfundingnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.AddForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentId",
                principalSchema: "capitalEquipment",
                principalTable: "CapitalEquipments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.AddForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentId",
                principalSchema: "capitalEquipment",
                principalTable: "CapitalEquipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
