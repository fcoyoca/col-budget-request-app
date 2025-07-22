using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.ProjectRequestSubGroup
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
                name: "ProjectRequestSubGroups",
                schema: "lookup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BudgetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubGroupTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubGroupSortOrder = table.Column<int>(type: "int", nullable: false),
                    SubGroupAbbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubGroupColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncludeSubGroupFundingBreakdownGraph = table.Column<bool>(type: "bit", nullable: false),
                    IncludeSubGroupFundingBreakdownTable = table.Column<bool>(type: "bit", nullable: false),
                    IncludeSubGroupExpenditureBreakdownGraph = table.Column<bool>(type: "bit", nullable: false),
                    IncludeSubGroupExpenditureBreakdownTable = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_ProjectRequestSubGroups", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectRequestSubGroups",
                schema: "lookup");
        }
    }
}
