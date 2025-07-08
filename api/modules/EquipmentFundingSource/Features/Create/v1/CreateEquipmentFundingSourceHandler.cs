using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
public sealed class CreateEquipmentFundingSourceHandler(
    ILogger<CreateEquipmentFundingSourceHandler> logger,
    [FromKeyedServices("EquipmentFundingSources")] IRepository<EquipmentFundingSourceItem> repository)
    : IRequestHandler<CreateEquipmentFundingSourceCommand, CreateEquipmentFundingSourceResponse>
{
    public async Task<CreateEquipmentFundingSourceResponse> Handle(CreateEquipmentFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = EquipmentFundingSourceItem.Create(
            request.SubId,
            request.SpecialCode,
            request.BudgetId,
            request.Title,
            request.Abbreviation,
            request.Code,
            request.SortOrder,
            request.IsNewBorrowing,
            request.FundingSource,
            request.FundingSubSource,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("EquipmentFundingSource item created {EquipmentFundingSourceItemId}", item.Id);
        return new CreateEquipmentFundingSourceResponse(item.Id);
    }
}
