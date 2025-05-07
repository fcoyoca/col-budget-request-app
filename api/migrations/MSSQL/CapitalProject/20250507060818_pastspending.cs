using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class pastspending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                schema: "capitalProject",
                table: "PastSpending",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIPItemNumber",
                schema: "capitalProject",
                table: "PastSpending",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                schema: "capitalProject",
                table: "PastSpending",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                schema: "capitalProject",
                table: "PastSpending",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                schema: "capitalProject",
                table: "PastSpending");

            migrationBuilder.DropColumn(
                name: "CIPItemNumber",
                schema: "capitalProject",
                table: "PastSpending");

            migrationBuilder.DropColumn(
                name: "Details",
                schema: "capitalProject",
                table: "PastSpending");

            migrationBuilder.DropColumn(
                name: "Year",
                schema: "capitalProject",
                table: "PastSpending");
        }
    }
}
