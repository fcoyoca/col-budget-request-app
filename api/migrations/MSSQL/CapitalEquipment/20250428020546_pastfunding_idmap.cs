using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class pastfunding_idmap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.DropIndex(
                name: "IX_PastFunding_CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.DropColumn(
                name: "CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.AddColumn<Guid>(
                name: "CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: null);

            migrationBuilder.CreateIndex(
                name: "IX_PastFunding_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.DropIndex(
                name: "IX_PastFunding_CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.DropColumn(
                name: "CapitalEquipmentId",
                schema: "capitalEquipment",
                table: "PastFunding");

            migrationBuilder.AddColumn<Guid>(
                name: "CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PastFunding_CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_PastFunding_CapitalEquipments_CapitalEquipmentItemId",
                schema: "capitalEquipment",
                table: "PastFunding",
                column: "CapitalEquipmentItemId",
                principalSchema: "capitalEquipment",
                principalTable: "CapitalEquipments",
                principalColumn: "Id");
        }
    }
}
