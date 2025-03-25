using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class capitalProject2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StatusTimelineId",
                schema: "capitalProject",
                table: "CapitalProjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatusTimeline",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartYearMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndYearMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentPointOfContactId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForMoreThanOneYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTimeline", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_StatusTimelineId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "StatusTimelineId");

            migrationBuilder.AddForeignKey(
                name: "FK_CapitalProjects_StatusTimeline_StatusTimelineId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "StatusTimelineId",
                principalSchema: "capitalProject",
                principalTable: "StatusTimeline",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CapitalProjects_StatusTimeline_StatusTimelineId",
                schema: "capitalProject",
                table: "CapitalProjects");

            migrationBuilder.DropTable(
                name: "StatusTimeline",
                schema: "capitalProject");

            migrationBuilder.DropIndex(
                name: "IX_CapitalProjects_StatusTimelineId",
                schema: "capitalProject",
                table: "CapitalProjects");

            migrationBuilder.DropColumn(
                name: "StatusTimelineId",
                schema: "capitalProject",
                table: "CapitalProjects");
        }
    }
}
