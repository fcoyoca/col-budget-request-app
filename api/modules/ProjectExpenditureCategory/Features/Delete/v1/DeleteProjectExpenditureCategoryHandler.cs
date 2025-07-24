using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using budget_request_app.WebApi.ProjectExpenditureCategory.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Delete.v1;
public sealed class DeleteProjectExpenditureCategoryHandler(
    ILogger<DeleteProjectExpenditureCategoryHandler> logger,
    [FromKeyedServices("ProjectExpenditureCategories")] IRepository<ProjectExpenditureCategoryItem> repository)
    : IRequestHandler<DeleteProjectExpenditureCategoryCommand>
{
    public async Task Handle(DeleteProjectExpenditureCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectExpenditureCategoryItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectExpenditureCategoryItem ?? throw new ProjectExpenditureCategoryItemNotFoundException(request.Id);
        await repository.DeleteAsync(ProjectExpenditureCategoryItem, cancellationToken);
        logger.LogInformation("ProjectExpenditureCategory with id : {ProjectExpenditureCategoryId} deleted", ProjectExpenditureCategoryItem.Id);
    }
}
