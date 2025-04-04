using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class fileIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileIds",
                schema: "capitalEquipment",
                table: "CapitalEquipments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileIds",
                schema: "capitalEquipment",
                table: "CapitalEquipments");
        }
    }
}
