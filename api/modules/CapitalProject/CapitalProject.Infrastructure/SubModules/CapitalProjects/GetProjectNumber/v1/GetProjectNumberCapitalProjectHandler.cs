using System.Reflection;
using budget_request_app.WebApi.BudgetYear.Domain;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;
using FSH.Framework.Core.Exceptions;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FSH.Framework.Core.Storage;
using FSH.Framework.Core.Storage.File;
using FSH.Framework.Core.Storage.File.Features;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.GetProjectNumber.v1;
public sealed class GetProjectNumberCapitalProjectHandler(
    IStorageService storageService,
    ILogger<GetProjectNumberCapitalProjectHandler> logger,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> budgetYearRepository,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository)
    : IRequestHandler<GetProjectNumberCapitalProjectRequest, GetProjectNumberCapitalProjectResponse>
{
    public async Task<GetProjectNumberCapitalProjectResponse> Handle(GetProjectNumberCapitalProjectRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var budgetYears = await budgetYearRepository.ListAsync();

        if (budgetYears.Count == 0)
        {
            await budgetYearRepository.AddAsync(new BudgetYearItem() { BudgetYear = DateTime.UtcNow.Year }, cancellationToken);
            budgetYears = await budgetYearRepository.ListAsync();
        }
        
        var maxBudgetYear = budgetYears.Select(x => x.BudgetYear).Max();
        
        var allEquipmentRequests = await repository.ListAsync();

        int requestNumber = 1;
        
        if (allEquipmentRequests.Any())
        {
            var currentYearRequests = allEquipmentRequests
                .Where(x => x.BudgetId.ToString() == maxBudgetYear.ToString());

            if (currentYearRequests.Any())
            {
                
                requestNumber = currentYearRequests
                    .Select(x => x.RequestNumber ?? 0)
                    .Max() + 1;
            }
        }
        
        var projectNumber = ( maxBudgetYear % 100 ) +  (requestNumber % 1000).ToString("D3");

        return new GetProjectNumberCapitalProjectResponse(projectNumber);
    }

}
