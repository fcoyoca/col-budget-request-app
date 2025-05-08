using budget_request_app.WebApi.CapitalProject.Domain;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

public class OperatingBudgetImpactDTO
{
    public List<OperatingCostDTO> OperatingCosts { get; set; }
    public List<OperatingRevenueDTO> OperatingRevenues { get; set; }
}

public class OperatingCostDTO
{
    public Guid? Id { get; set; }
    public Guid FundingSourceId { get; set; }
    public string? FundingSourceValue { get; set; }
    public Guid DepartmentId { get; set; }
    public string? DepartmentValue { get; set; }
    public string Description { get; set; }
    public int FTCount { get; set; }
    public decimal Amount { get; set; }
}

public class OperatingRevenueDTO
{
    public Guid? Id { get; set; }
    public Guid FundingSourceId { get; set; }
    public string? FundingSourceValue { get; set; }
    public Guid DepartmentId { get; set; }
    public string? DepartmentValue { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
}
