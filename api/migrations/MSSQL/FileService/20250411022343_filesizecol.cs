using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.FileService
{
    /// <inheritdoc />
    public partial class filesizecol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Size",
                schema: "fileService",
                table: "FileServiceItem",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                schema: "fileService",
                table: "FileServiceItem");
        }
    }
}
