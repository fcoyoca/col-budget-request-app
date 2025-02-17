using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.LookupCategory
{
    /// <inheritdoc />
    public partial class moduleid_col : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                schema: "lookup",
                table: "LookupCategories",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModuleId",
                schema: "lookup",
                table: "LookupCategories");
        }
    }
}
