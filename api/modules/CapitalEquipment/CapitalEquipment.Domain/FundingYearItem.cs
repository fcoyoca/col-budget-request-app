using budget_request_app.WebApi.CapitalEquipment.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalEquipment.Domain;

public class FundingYearItem : AuditableEntity, IAggregateRoot
{
    public int? Year { get; set; }
    public decimal? Value { get; set; }
    
    public static FundingYearItem Create(
        int year,
        decimal? value
    )
    {
        var data = new FundingYearItem();
        data.Year = year;
        data.Value = value;
        
        data.QueueDomainEvent(new FundingYearItemCreated() { FundingYearItem = data });

        return data;
    }
    
    public static FundingYearItem Update(
        Guid id,
        int year,
        decimal? value
    )
    {
        var data = new FundingYearItem()
        {
            Id = id,
            Year = year,
            Value = value
        };
        
        data.QueueDomainEvent(new FundingYearItemCreated() { FundingYearItem = data });

        return data;
    }
}
