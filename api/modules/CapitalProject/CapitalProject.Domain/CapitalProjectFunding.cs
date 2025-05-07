using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class CapitalProjectFunding : AuditableEntity, IAggregateRoot
{
    
    
}

public class CapitalProjectFundingBase : AuditableEntity, IAggregateRoot
{
    public Guid? ExpenditureCategoryId { get; set; } = Guid.Empty;
    public FundingYearItem? YearRequested { get; set; }
    public List<FundingYearItem>? YearEstimates { get; set; } = new();
}


public class BorrowingFunding : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class OperatingFunding : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class GrantFunding : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
    public string? GrantingAgency { get; set; }
    public decimal? CashMatchPercentage { get; set; }
    public decimal? CashMatchAmount { get; set; }
    public string? Description { get; set; }
}

public class DonationFunding : CapitalProjectFundingBase
{
    public Guid? FundingTypeId { get; set; }
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class SpecialFunding : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class OtherFunding : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
    public string? Description { get; set; } = string.Empty;
}

public class SpendingBudget : CapitalProjectFundingBase
{
    public Guid? SpendingPurposeId { get; set; } = Guid.Empty;
}
public class FundingYearItem : AuditableEntity, IAggregateRoot
{
    public int? Year { get; set; }
    public decimal? Value { get; set; }
}

public class FundingChange : AuditableEntity, IAggregateRoot
{
    public Guid? ChangeSetId { get; set; }
    public string? ChangeTypeIds { get; set; }
    public string? Changes { get; set; }
}

public class PastFunding : AuditableEntity, IAggregateRoot
{
    public Guid? ExpenditureCategoryId { get; set; }
    public string? SourceOfFunds { get; set; }
    public string? Details { get; set; }
    public int? Year { get; set; }
    public decimal? Amount { get; set; }
    public string? CIPItemNumber { get; set; }
    public Guid? FundingSourceId { get; set; }
    public Guid? FundingSubSourceId { get; set; }
}

public class PastSpending : AuditableEntity, IAggregateRoot
{
    public Guid? ExpenditureCategoryId { get; set; }
    public Guid? SpendingPurposeId { get; set; } = Guid.Empty;
    public string? Details { get; set; }
    public int? Year { get; set; }
    public decimal? Amount { get; set; }
    public string? CIPItemNumber { get; set; }
}
