using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using budget_request_app.WebApi.ProjectExpenditureCategory.Exceptions;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Deactivate.v1;
public sealed class DeactivateProjectExpenditureCategoryHandler(
    ILogger<DeactivateProjectExpenditureCategoryHandler> logger,
    [FromKeyedServices("ProjectExpenditureCategories")] IRepository<ProjectExpenditureCategoryItem> repository)
    : IRequestHandler<DeactivateProjectExpenditureCategoryCommand, DeactivateProjectExpenditureCategoryResponse>
{
    public async Task<DeactivateProjectExpenditureCategoryResponse> Handle(DeactivateProjectExpenditureCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectExpenditureCategory = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectExpenditureCategory ?? throw new ProjectExpenditureCategoryItemNotFoundException(request.Id);
        ProjectExpenditureCategory.IsActive = false;
        await repository.UpdateAsync(ProjectExpenditureCategory, cancellationToken);
        logger.LogInformation("ProjectExpenditureCategory item Deactivate {ProjectExpenditureCategoryItemId}", ProjectExpenditureCategory.Id);
        return new DeactivateProjectExpenditureCategoryResponse(ProjectExpenditureCategory.Id);
    }
}
