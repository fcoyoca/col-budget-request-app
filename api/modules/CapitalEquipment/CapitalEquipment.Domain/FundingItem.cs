using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using budget_request_app.WebApi.CapitalEquipment.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalEquipment.Domain;
public class FundingItem : AuditableEntity, IAggregateRoot
{
    public string FundingType  { get; set; }
    public Guid? FundingSource { get; set; } = Guid.Empty;
    public string? GrantingAgency { get; set; }
    public FundingYearItem? CurrentYearRequested { get; set; }
    public List<FundingYearItem>? YearEstimates { get; set; } = new();
    public Guid CapitalEquipmentId { get; set; } = Guid.Empty;
    [NotMapped, JsonIgnore]
    public CapitalEquipmentItem? CapitalEquipment { get; set; }

    public static FundingItem Create(
        string fundingType,
        Guid fundingSource,
        string? grantingAgency,
        FundingYearItem? currentYearRequested,
        List<FundingYearItem>? yearEstimates,
        Guid capitalEquipmentId
        )
    {
        var data = new FundingItem();

        data.FundingType = fundingType;
        data.FundingSource = fundingSource;
        data.GrantingAgency = grantingAgency;
        data.CurrentYearRequested = currentYearRequested;
        data.YearEstimates = yearEstimates ?? new List<FundingYearItem>();
        data.CapitalEquipmentId = capitalEquipmentId;

        data.QueueDomainEvent(new FundingItemCreated() { FundingItem = data });

        return data;
    }

    public static FundingItem Update(
        Guid id,
        Guid? fundingSource,
        string? grantingAgency,
        FundingYearItem? currentYearRequested,
        List<FundingYearItem>? yearEstimates
    )
    {
        var data = new FundingItem
        {
            Id = id,
            FundingSource = fundingSource,
            GrantingAgency = grantingAgency,
            CurrentYearRequested = currentYearRequested,
            YearEstimates = yearEstimates ?? new List<FundingYearItem>()
        };

        data.QueueDomainEvent(new FundingItemUpdated() { FundingItem = data });

        return data;
    }
}
