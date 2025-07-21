using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using budget_request_app.WebApi.ProjectExpenditureCategory.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
public sealed class ActivateProjectExpenditureCategoryHandler(
    ILogger<ActivateProjectExpenditureCategoryHandler> logger,
    [FromKeyedServices("ProjectExpenditureCategories")] IRepository<ProjectExpenditureCategoryItem> repository)
    : IRequestHandler<ActivateProjectExpenditureCategoryCommand, ActivateProjectExpenditureCategoryResponse>
{
    public async Task<ActivateProjectExpenditureCategoryResponse> Handle(ActivateProjectExpenditureCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectExpenditureCategory = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectExpenditureCategory ?? throw new ProjectExpenditureCategoryItemNotFoundException(request.Id.Value);
        ProjectExpenditureCategory.IsActive = true;
        await repository.UpdateAsync(ProjectExpenditureCategory, cancellationToken);
        logger.LogInformation("ProjectExpenditureCategory item Activated {ProjectExpenditureCategoryItemId}", ProjectExpenditureCategory.Id);
        return new ActivateProjectExpenditureCategoryResponse(ProjectExpenditureCategory.Id);
    }
}
