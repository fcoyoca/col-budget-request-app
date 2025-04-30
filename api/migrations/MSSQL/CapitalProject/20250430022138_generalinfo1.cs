using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class generalinfo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RequiresTwoThirdsApproval",
                schema: "capitalProject",
                table: "GeneralInformation",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiresTwoThirdsApproval",
                schema: "capitalProject",
                table: "GeneralInformation");
        }
    }
}
