using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class projectrankscore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ProjectRankScore",
                schema: "capitalProject",
                table: "JustificationPrioritization",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectScoreYear",
                schema: "capitalProject",
                table: "JustificationPrioritization",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectRankScore",
                schema: "capitalProject",
                table: "JustificationPrioritization");

            migrationBuilder.DropColumn(
                name: "ProjectScoreYear",
                schema: "capitalProject",
                table: "JustificationPrioritization");
        }
    }
}
