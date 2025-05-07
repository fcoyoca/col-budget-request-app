namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

public class FinancialDTO
{
    public FundingDTO? Funding { get; set; }
    public SpendingDTO? Spending { get; set; }
    public ChangeDTO? Change { get; set; }
    public PastDTO? Past { get; set; }
}

public class FundingDTO
{
    public string? TIFFundingIds { get; set; }
    public List<BorrowingFundingDTO>? BorrowingFundings { get; set; }
    public List<OperatingFundingDTO>? OperatingFundings { get; set; }
    public List<GrantFundingDTO>? GrantFundings { get; set; }
    public DonationFundingParentDTO? DonationFunding { get; set; }
    public List<SpecialFundingDTO>? SpecialFundings { get; set; }
    public List<OtherFundingDTO>? OtherFundings { get; set; }
}

public class SpendingDTO
{
    public List<SpendingBudgetDTO> SpendingBudgets { get; set; }
}

public class ChangeDTO
{
    public List<FundingChangeDTO>? FundingChanges { get; set; }
}

public class PastDTO
{
    public List<PastFundingDTO>? PastFundings { get; set; }
    public List<PastSpendingDTO>? PastSpendings { get; set; }
}

public class DonationFundingParentDTO
{
    public bool? DonationFundingIsContributeFundsRequired { get; set; }
    public bool? DonationFundingIsDonatedFundsUsed { get; set; }
    public decimal? AmountAdvanced { get; set; }
    public string? AdvancedFundsDescription { get; set; }
    public decimal? DonatedAmountCollected { get; set; }
    public decimal? AmountDonated { get; set; }
    public string? DonationArrangements { get; set; }
    public List<DonationFundingDTO>? DonationFundings { get; set; }
}

public class CapitalProjectFundingBase
{
    public Guid? Id { get; set; }
    public Guid? ExpenditureCategoryId { get; set; } = Guid.Empty;
    public string? ExpenditureCategoryName { get; set; }
    public string? FundingSourceName { get; set; }
    
    public FundingYearItemDTO? YearRequested { get; set; }
    public List<FundingYearItemDTO>? YearEstimates { get; set; } = new();
}


public class BorrowingFundingDTO : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class OperatingFundingDTO : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class GrantFundingDTO : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
    public string? GrantingAgency { get; set; }
    public decimal? CashMatchPercentage { get; set; }
    public decimal? CashMatchAmount { get; set; }
    public string? Description { get; set; }
}

public class DonationFundingDTO : CapitalProjectFundingBase
{
    public Guid? FundingTypeId { get; set; }
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class SpecialFundingDTO : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
}

public class OtherFundingDTO : CapitalProjectFundingBase
{
    public Guid? FundingSourceId { get; set; } = Guid.Empty;
    public string? Description { get; set; } = string.Empty;
}

public class SpendingBudgetDTO : CapitalProjectFundingBase
{
    public Guid? SpendingPurposeId { get; set; } = Guid.Empty;
    public string? SpendingPurposeName { get; set; }
}
public class FundingYearItemDTO
{
    public Guid Id { get; set; }
    public int? Year { get; set; }
    public decimal? Value { get; set; }
}

public class FundingChangeDTO
{
    public Guid Id { get; set; }
    public Guid? ChangeSetId { get; set; }
    public string? ChangeSetValue { get; set; }
    public string? ChangeTypeIds { get; set; }
    public string? ChangeTypeValue { get; set; }
    public string? Changes { get; set; }
}

public class PastFundingDTO
{
    public Guid Id { get; set; }
    public Guid? ExpenditureCategoryId { get; set; }
    public string? ExpenditureCategoryName { get; set; }
    public string? SourceOfFunds { get; set; }
    public string? Details { get; set; }
    public int? Year { get; set; }
    public decimal? Amount { get; set; }
    public string? CIPItemNumber { get; set; }
    public Guid? FundingSourceId { get; set; }
    public string? FundingSourceName { get; set; }
    public Guid? FundingSubSourceId { get; set; }
    public string? FundingSubSourceName { get; set; }
}

public class PastSpendingDTO
{
    public Guid Id { get; set; }
    public Guid? ExpenditureCategoryId { get; set; }
    public string? ExpenditureCategoryName { get; set; }
    public Guid? SpendingPurposeId { get; set; } = Guid.Empty;
    public string? SpendingPurposeName { get; set; }
    
    public string? Details { get; set; }
    public int? Year { get; set; }
    public decimal? Amount { get; set; }
    public string? CIPItemNumber { get; set; }
}
