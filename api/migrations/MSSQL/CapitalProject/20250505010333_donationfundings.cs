using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class donationfundings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdvancedFundsDescription",
                schema: "capitalProject",
                table: "CapitalProjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountAdvanced",
                schema: "capitalProject",
                table: "CapitalProjects",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountDonated",
                schema: "capitalProject",
                table: "CapitalProjects",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DonatedAmountCollected",
                schema: "capitalProject",
                table: "CapitalProjects",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DonationArrangements",
                schema: "capitalProject",
                table: "CapitalProjects",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvancedFundsDescription",
                schema: "capitalProject",
                table: "CapitalProjects");

            migrationBuilder.DropColumn(
                name: "AmountAdvanced",
                schema: "capitalProject",
                table: "CapitalProjects");

            migrationBuilder.DropColumn(
                name: "AmountDonated",
                schema: "capitalProject",
                table: "CapitalProjects");

            migrationBuilder.DropColumn(
                name: "DonatedAmountCollected",
                schema: "capitalProject",
                table: "CapitalProjects");

            migrationBuilder.DropColumn(
                name: "DonationArrangements",
                schema: "capitalProject",
                table: "CapitalProjects");
        }
    }
}
