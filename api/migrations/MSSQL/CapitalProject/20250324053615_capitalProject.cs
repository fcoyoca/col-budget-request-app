using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_request_app.WebApi.Migrations.MSSQL.CapitalProject
{
    /// <inheritdoc />
    public partial class capitalProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "capitalProject");

            migrationBuilder.CreateTable(
                name: "ApprovalOversight",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartOfApprovedMasterPlan = table.Column<bool>(type: "bit", nullable: true),
                    HasRequestBeenApprovedByOversight = table.Column<bool>(type: "bit", nullable: true),
                    ApprovingOversightBoardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateOfOversightApproval = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LegistarApprovalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRequiredOtherApproval = table.Column<bool>(type: "bit", nullable: true),
                    HasReceivedOtherApproval = table.Column<bool>(type: "bit", nullable: true),
                    ReceivedOtherApprovals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemainingOtherApprovals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalOversight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralInformation",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: true),
                    RequestStatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestingDepartmentIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentHeadRequestorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarksPrintout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestGroupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrantFundingOpportunity",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrantFundingOpportunities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeSpentReviewingGrantFunding = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WasCongressionallyDirectedSpendingRequestMade = table.Column<bool>(type: "bit", nullable: true),
                    CongressionallyDirectedSpendingRequestOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantFundingOpportunity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JustificationPrioritization",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentPriorityRanking = table.Column<int>(type: "int", nullable: true),
                    DesiredOutcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcomeMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetDetermination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SustainabilityGoals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JustificationPrioritization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagement",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MunisAccounts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapitalProjects",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BudgetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JustificationPrioritizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GrantFundingOpportunityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApprovalOversightId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsMappedRequest = table.Column<bool>(type: "bit", nullable: true),
                    GISMappingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonationFundingIsContributeFundsRequired = table.Column<bool>(type: "bit", nullable: true),
                    DonationFundingIsDonatedFundsUsed = table.Column<bool>(type: "bit", nullable: true),
                    ProjectManagementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_CapitalProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CapitalProjects_ApprovalOversight_ApprovalOversightId",
                        column: x => x.ApprovalOversightId,
                        principalSchema: "capitalProject",
                        principalTable: "ApprovalOversight",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_GeneralInformation_GeneralInformationId",
                        column: x => x.GeneralInformationId,
                        principalSchema: "capitalProject",
                        principalTable: "GeneralInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_GrantFundingOpportunity_GrantFundingOpportunityId",
                        column: x => x.GrantFundingOpportunityId,
                        principalSchema: "capitalProject",
                        principalTable: "GrantFundingOpportunity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_JustificationPrioritization_JustificationPrioritizationId",
                        column: x => x.JustificationPrioritizationId,
                        principalSchema: "capitalProject",
                        principalTable: "JustificationPrioritization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_ProjectManagement_ProjectManagementId",
                        column: x => x.ProjectManagementId,
                        principalSchema: "capitalProject",
                        principalTable: "ProjectManagement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FundingChange",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChangeSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangeTypeIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingChange", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundingChange_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MinorProject",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinorProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MinorProject_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperatingCost",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FTCount = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingCost_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperatingRevenue",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingRevenue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingRevenue_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PastFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SourceOfFunds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CIPItemNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FundingSubSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PastSpending",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpendingPurposeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastSpending", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastSpending_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StreetSegment",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PavementRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurbRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurbAndGutter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightOfWay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyImprovements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UtilityWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetscapingLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sidewalks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetSegment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StreetSegment_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BorrowingFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowingFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowingFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DonationFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FundingYearItem",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BorrowingFundingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DonationFundingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GrantFundingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OperatingFundingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OtherFundingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpecialFundingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpendingBudgetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingYearItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundingYearItem_BorrowingFunding_BorrowingFundingId",
                        column: x => x.BorrowingFundingId,
                        principalSchema: "capitalProject",
                        principalTable: "BorrowingFunding",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FundingYearItem_DonationFunding_DonationFundingId",
                        column: x => x.DonationFundingId,
                        principalSchema: "capitalProject",
                        principalTable: "DonationFunding",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GrantFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GrantingAgency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashMatchPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CashMatchAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrantFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantFunding_FundingYearItem_YearRequestedId",
                        column: x => x.YearRequestedId,
                        principalSchema: "capitalProject",
                        principalTable: "FundingYearItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperatingFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperatingFunding_FundingYearItem_YearRequestedId",
                        column: x => x.YearRequestedId,
                        principalSchema: "capitalProject",
                        principalTable: "FundingYearItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OtherFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherFunding_FundingYearItem_YearRequestedId",
                        column: x => x.YearRequestedId,
                        principalSchema: "capitalProject",
                        principalTable: "FundingYearItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpecialFunding",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FundingSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialFunding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialFunding_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpecialFunding_FundingYearItem_YearRequestedId",
                        column: x => x.YearRequestedId,
                        principalSchema: "capitalProject",
                        principalTable: "FundingYearItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpendingBudget",
                schema: "capitalProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpendingPurposeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapitalProjectItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenditureCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearRequestedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpendingBudget", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpendingBudget_CapitalProjects_CapitalProjectItemId",
                        column: x => x.CapitalProjectItemId,
                        principalSchema: "capitalProject",
                        principalTable: "CapitalProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpendingBudget_FundingYearItem_YearRequestedId",
                        column: x => x.YearRequestedId,
                        principalSchema: "capitalProject",
                        principalTable: "FundingYearItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "BorrowingFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingFunding_YearRequestedId",
                schema: "capitalProject",
                table: "BorrowingFunding",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_ApprovalOversightId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "ApprovalOversightId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_GeneralInformationId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "GeneralInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_GrantFundingOpportunityId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "GrantFundingOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_JustificationPrioritizationId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "JustificationPrioritizationId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_ProjectManagementId",
                schema: "capitalProject",
                table: "CapitalProjects",
                column: "ProjectManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "DonationFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationFunding_YearRequestedId",
                schema: "capitalProject",
                table: "DonationFunding",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingChange_CapitalProjectItemId",
                schema: "capitalProject",
                table: "FundingChange",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_BorrowingFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "BorrowingFundingId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_DonationFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "DonationFundingId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_GrantFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "GrantFundingId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_OperatingFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "OperatingFundingId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_OtherFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "OtherFundingId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_SpecialFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "SpecialFundingId");

            migrationBuilder.CreateIndex(
                name: "IX_FundingYearItem_SpendingBudgetId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "SpendingBudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "GrantFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantFunding_YearRequestedId",
                schema: "capitalProject",
                table: "GrantFunding",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_MinorProject_CapitalProjectItemId",
                schema: "capitalProject",
                table: "MinorProject",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingCost_CapitalProjectItemId",
                schema: "capitalProject",
                table: "OperatingCost",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "OperatingFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingFunding_YearRequestedId",
                schema: "capitalProject",
                table: "OperatingFunding",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingRevenue_CapitalProjectItemId",
                schema: "capitalProject",
                table: "OperatingRevenue",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "OtherFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherFunding_YearRequestedId",
                schema: "capitalProject",
                table: "OtherFunding",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_PastFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "PastFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PastSpending_CapitalProjectItemId",
                schema: "capitalProject",
                table: "PastSpending",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialFunding_CapitalProjectItemId",
                schema: "capitalProject",
                table: "SpecialFunding",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialFunding_YearRequestedId",
                schema: "capitalProject",
                table: "SpecialFunding",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_SpendingBudget_CapitalProjectItemId",
                schema: "capitalProject",
                table: "SpendingBudget",
                column: "CapitalProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SpendingBudget_YearRequestedId",
                schema: "capitalProject",
                table: "SpendingBudget",
                column: "YearRequestedId");

            migrationBuilder.CreateIndex(
                name: "IX_StreetSegment_CapitalProjectItemId",
                schema: "capitalProject",
                table: "StreetSegment",
                column: "CapitalProjectItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowingFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "BorrowingFunding",
                column: "YearRequestedId",
                principalSchema: "capitalProject",
                principalTable: "FundingYearItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "DonationFunding",
                column: "YearRequestedId",
                principalSchema: "capitalProject",
                principalTable: "FundingYearItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingYearItem_GrantFunding_GrantFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "GrantFundingId",
                principalSchema: "capitalProject",
                principalTable: "GrantFunding",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingYearItem_OperatingFunding_OperatingFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "OperatingFundingId",
                principalSchema: "capitalProject",
                principalTable: "OperatingFunding",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingYearItem_OtherFunding_OtherFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "OtherFundingId",
                principalSchema: "capitalProject",
                principalTable: "OtherFunding",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingYearItem_SpecialFunding_SpecialFundingId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "SpecialFundingId",
                principalSchema: "capitalProject",
                principalTable: "SpecialFunding",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingYearItem_SpendingBudget_SpendingBudgetId",
                schema: "capitalProject",
                table: "FundingYearItem",
                column: "SpendingBudgetId",
                principalSchema: "capitalProject",
                principalTable: "SpendingBudget",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowingFunding_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "BorrowingFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_DonationFunding_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "DonationFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantFunding_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "GrantFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_OperatingFunding_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "OperatingFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherFunding_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "OtherFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialFunding_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "SpecialFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_SpendingBudget_CapitalProjects_CapitalProjectItemId",
                schema: "capitalProject",
                table: "SpendingBudget");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowingFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "BorrowingFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_DonationFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "DonationFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "GrantFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_OperatingFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "OperatingFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "OtherFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialFunding_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "SpecialFunding");

            migrationBuilder.DropForeignKey(
                name: "FK_SpendingBudget_FundingYearItem_YearRequestedId",
                schema: "capitalProject",
                table: "SpendingBudget");

            migrationBuilder.DropTable(
                name: "FundingChange",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "MinorProject",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "OperatingCost",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "OperatingRevenue",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "PastFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "PastSpending",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "StreetSegment",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "CapitalProjects",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "ApprovalOversight",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "GeneralInformation",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "GrantFundingOpportunity",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "JustificationPrioritization",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "ProjectManagement",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "FundingYearItem",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "BorrowingFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "DonationFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "GrantFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "OperatingFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "OtherFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "SpecialFunding",
                schema: "capitalProject");

            migrationBuilder.DropTable(
                name: "SpendingBudget",
                schema: "capitalProject");
        }
    }
}
