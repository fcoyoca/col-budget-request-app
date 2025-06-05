using System.Runtime.InteropServices.JavaScript;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using FSH.Framework.Core.Exceptions;
using FSH.Framework.Core.Persistence;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.GetProjectNumber.v1;
public sealed class GetProjectNumberCapitalEquipmentHandler(
    ILogger<GetProjectNumberCapitalEquipmentHandler> logger,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> budgetYearRepository,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository)
    : IRequestHandler<GetProjectNumberCapitalEquipmentRequest, GetProjectNumberCapitalEquipmentResponse>
{
    public async Task<GetProjectNumberCapitalEquipmentResponse> Handle(GetProjectNumberCapitalEquipmentRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var budgetYears = await budgetYearRepository.ListAsync();

        if (budgetYears.Count == 0)
        {
            throw new NotFoundException("budget year not found");
        }
        
        var maxBudgetYear = budgetYears.Select(x => x.BudgetYear).Max();
        
        var allEquipmentRequests = await repository.ListAsync();

        int requestNumber = 0;
        
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
        
        var projectNumber = ( maxBudgetYear % 100 ) + "-" + (requestNumber % 1000).ToString("D3");

        return new GetProjectNumberCapitalEquipmentResponse(projectNumber);
    }
}
