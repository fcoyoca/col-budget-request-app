using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalEquipment
{
    /// <inheritdoc />
    public partial class capitalEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "capitalEquipment");

            migrationBuilder.CreateTable(
                name: "CapitalEquipments",
                schema: "capitalEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BudgetId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestStatusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RemarksPrintout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestingDepartmentIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentHeadRequestorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentCategoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsReplacement = table.Column<bool>(type: "bit", nullable: false),
                    IsLeasedVehicle = table.Column<bool>(type: "bit", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EquipmentSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentPriorityRanking = table.Column<int>(type: "int", nullable: true),
                    ExpectedOutcomes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurposeOfExpenditure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JustificationForReplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredMandatedPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaybackPeriodPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SustainabilityPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostToOperatePriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevenueGenerationPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredMandatedExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaybackPeriodExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SustainabilityExplanation= table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostToOperateExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevenueGenerationExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetBeingReplaced = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConditionOfAssetBeingReplaced = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdometerReadingHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardReplacementCycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedLifeOfEquipment = table.Column<int>(type: "int", nullable: true),
                    DepartmentResponsibleForOperatingCosts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnualOperatingCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AnnualRevenueFromEquipment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasPurchaseBeenApprovedByOversight = table.Column<bool>(type: "bit", nullable: true),
                    LegistarApprovalItemNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovingOversightBoard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfOversightApproval = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchasingBuyerReview = table.Column<bool>(type: "bit", nullable: true),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_CapitalEquipments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapitalEquipments",
                schema: "capitalEquipment");
        }
    }
}
