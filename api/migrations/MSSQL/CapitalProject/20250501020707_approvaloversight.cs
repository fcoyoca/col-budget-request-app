using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class approvaloversight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedMasterPlanDate",
                schema: "capitalProject",
                table: "ApprovalOversight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovedMasterPlanTitle",
                schema: "capitalProject",
                table: "ApprovalOversight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequireOtherApproval",
                schema: "capitalProject",
                table: "ApprovalOversight",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedMasterPlanDate",
                schema: "capitalProject",
                table: "ApprovalOversight");

            migrationBuilder.DropColumn(
                name: "ApprovedMasterPlanTitle",
                schema: "capitalProject",
                table: "ApprovalOversight");

            migrationBuilder.DropColumn(
                name: "RequireOtherApproval",
                schema: "capitalProject",
                table: "ApprovalOversight");
        }
    }
}
