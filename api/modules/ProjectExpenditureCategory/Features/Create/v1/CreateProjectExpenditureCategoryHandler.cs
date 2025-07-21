using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
public sealed class CreateProjectExpenditureCategoryHandler(
    ILogger<CreateProjectExpenditureCategoryHandler> logger,
    [FromKeyedServices("ProjectExpenditureCategories")] IRepository<ProjectExpenditureCategoryItem> repository)
    : IRequestHandler<CreateProjectExpenditureCategoryCommand, CreateProjectExpenditureCategoryResponse>
{
    public async Task<CreateProjectExpenditureCategoryResponse> Handle(CreateProjectExpenditureCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = ProjectExpenditureCategoryItem.Create(
            request.SubId,
            request.Category,
            request.SubCategory,
            request.SubSubCategory,
            request.ShortDisplayName,
            request.BudgetId,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("ProjectExpenditureCategory item created {ProjectExpenditureCategoryItemId}", item.Id);
        return new CreateProjectExpenditureCategoryResponse(item.Id);
    }
}
