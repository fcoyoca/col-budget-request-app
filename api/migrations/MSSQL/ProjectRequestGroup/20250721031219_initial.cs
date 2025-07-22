using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.ProjectRequestGroup
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lookup");

            migrationBuilder.CreateTable(
                name: "ProjectRequestGroups",
                schema: "lookup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BudgetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupSortOrder = table.Column<int>(type: "int", nullable: false),
                    GroupAbbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncludeGroupFundingBreakdownGraph = table.Column<bool>(type: "bit", nullable: false),
                    IncludeGroupFundingBreakdownTable = table.Column<bool>(type: "bit", nullable: false),
                    IncludeGroupExpenditureBreakdownGraph = table.Column<bool>(type: "bit", nullable: false),
                    IncludeGroupExpenditureBreakdownTable = table.Column<bool>(type: "bit", nullable: false),
                    IsEquipmentGroup = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LookupValueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRequestGroups", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectRequestGroups",
                schema: "lookup");
        }
    }
}
