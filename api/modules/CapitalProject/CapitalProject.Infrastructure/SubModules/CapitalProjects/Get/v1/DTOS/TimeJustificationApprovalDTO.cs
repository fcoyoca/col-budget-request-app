namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

public class TimeJustificationApprovalDTO
{
   public JustificationPrioritizationDTO? JustificationPrioritization { get; set; }
   public StatusTimelineDTO? StatusTimeline { get; set; }
   public GrantFundingOpportunityDTO? GrantFundingOpportunity { get; set; }
   public ApprovalOversightDTO? ApprovalOversight { get; set; }
}

public class JustificationPrioritizationDTO
{
    public Guid? Id { get; set; }
    public int? DepartmentPriorityRanking { get; set; } = 0;
    public string? DesiredOutcome { get; set; }
    public string? OutcomeMeasurement { get; set; }
    public string? BudgetDetermination { get; set; }
    public string? SustainabilityGoals { get; set; }
}

public class StatusTimelineDTO
{
    public Guid? Id { get; set; }
    public string? StartYearMonth { get; set; }
    public string? EndYearMonth { get; set; }
    public string? CurrentStatus { get; set; }
    public string? DepartmentPointOfContactId { get; set; }
    public string? ReasonForMoreThanOneYear { get; set; }
}

public class GrantFundingOpportunityDTO
{
    public Guid? Id { get; set; }
    public string? GrantFundingOpportunities { get; set; }
    public decimal? TimeSpentReviewingGrantFunding { get; set; }
    public bool? WasCongressionallyDirectedSpendingRequestMade { get; set; } = false;
    public string? CongressionallyDirectedSpendingRequestOffice { get; set; }
}

public class ApprovalOversightDTO
{
    public Guid? Id { get; set; }
    public bool? PartOfApprovedMasterPlan  { get; set; } = false;
    public bool? HasRequestBeenApprovedByOversight { get; set; } = false;
    public Guid? ApprovingOversightBoardId { get; set; }
    public DateTime? DateOfOversightApproval { get; set; }
    public string? LegistarApprovalNumber { get; set; }
    public bool? HasRequiredOtherApproval { get; set; } = false;
    public bool? RequireOtherApproval { get; set; } = false;
    public bool? HasReceivedOtherApproval { get; set; } = false;
    public string? ReceivedOtherApprovals { get; set; }
    public string? RemainingOtherApprovals { get; set; }
}
