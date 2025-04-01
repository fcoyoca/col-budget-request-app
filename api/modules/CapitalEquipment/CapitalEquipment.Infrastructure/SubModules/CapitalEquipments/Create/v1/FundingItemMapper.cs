using budget_request_app.WebApi.CapitalEquipment.Domain;
using Mapster;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;

public static class FundingItemMapper
{
    public static List<FundingItem> MapFundingItems(List<FundingItemCreateDTO> fundingCreateItems, string fundingType)
    {
        foreach (FundingItemCreateDTO fundingItemCreateDto in fundingCreateItems)
        {
            //fundingItemCreateDto.Id = Guid.NewGuid();
        }
        
        if (fundingCreateItems == null)
        {
            fundingCreateItems = new List<FundingItemCreateDTO>();
        }

        var fundingItems = new List<FundingItem>();

        if (fundingCreateItems != null)
        {
            fundingItems = fundingCreateItems.Adapt<List<FundingItem>>();
        }

        foreach (FundingItem fundingItem in fundingItems)
        {
            fundingItem.FundingType = fundingType;
        }

        return fundingItems;
    }
}
