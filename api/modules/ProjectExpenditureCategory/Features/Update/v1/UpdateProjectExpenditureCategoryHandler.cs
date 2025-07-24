using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using budget_request_app.WebApi.ProjectExpenditureCategory.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Update.v1;

public sealed class UpdateProjectExpenditureCategoryHandler(
    ILogger<UpdateProjectExpenditureCategoryHandler> logger,
    [FromKeyedServices("ProjectExpenditureCategories")] IRepository<ProjectExpenditureCategoryItem> repository)
    : IRequestHandler<UpdateProjectExpenditureCategoryCommand, UpdateProjectExpenditureCategoryResponse>
{
    public async Task<UpdateProjectExpenditureCategoryResponse> Handle(UpdateProjectExpenditureCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var projectExpenditureCategory = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = projectExpenditureCategory ?? throw new ProjectExpenditureCategoryItemNotFoundException(request.Id);

        // Update properties
        projectExpenditureCategory.SubId = request.SubId;
        projectExpenditureCategory.Category = request.Category;
        projectExpenditureCategory.SubCategory = request.SubCategory;
        projectExpenditureCategory.SubSubCategory = request.SubSubCategory;
        projectExpenditureCategory.ShortDisplayName = request.ShortDisplayName;
        projectExpenditureCategory.BudgetId = request.BudgetId;
        await repository.UpdateAsync(projectExpenditureCategory, cancellationToken);

        logger.LogInformation("ProjectExpenditureCategory item updated: {ProjectExpenditureCategoryItemId}", projectExpenditureCategory.Id);

        return new UpdateProjectExpenditureCategoryResponse(projectExpenditureCategory.Id);
    }
}
