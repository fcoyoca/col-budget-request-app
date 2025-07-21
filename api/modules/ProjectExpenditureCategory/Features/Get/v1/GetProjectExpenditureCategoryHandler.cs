using System;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using budget_request_app.WebApi.ProjectExpenditureCategory.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
public sealed class GetProjectExpenditureCategoryHandler(
    [FromKeyedServices("ProjectExpenditureCategories")] IReadRepository<ProjectExpenditureCategoryItem> repository,
    ICacheService cache)
    : IRequestHandler<GetProjectExpenditureCategoryRequest, GetProjectExpenditureCategoryResponse>
{
    public async Task<GetProjectExpenditureCategoryResponse> Handle(GetProjectExpenditureCategoryRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"ProjectExpenditureCategory:{request.Id}",
            async () =>
            {
                var ProjectExpenditureCategoryItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (ProjectExpenditureCategoryItem == null) throw new ProjectExpenditureCategoryItemNotFoundException(request.Id);
                return new GetProjectExpenditureCategoryResponse(
                    ProjectExpenditureCategoryItem.Id,
                    ProjectExpenditureCategoryItem.SubId,
                    ProjectExpenditureCategoryItem.Category,
                    ProjectExpenditureCategoryItem.SubCategory,
                    ProjectExpenditureCategoryItem.SubSubCategory,
                    ProjectExpenditureCategoryItem.ShortDisplayName,
                    ProjectExpenditureCategoryItem.BudgetId,
                    ProjectExpenditureCategoryItem.LookupValueId
                    );
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}

