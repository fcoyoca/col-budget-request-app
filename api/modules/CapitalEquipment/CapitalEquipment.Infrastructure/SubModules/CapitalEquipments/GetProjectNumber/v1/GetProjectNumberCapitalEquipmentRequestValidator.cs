using budget_request_app.WebApi.CapitalEquipment.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.GetProjectNumber.v1;
public class GetProjectNumberCapitalEquipmentRequestValidator : AbstractValidator<GetProjectNumberCapitalEquipmentRequest>
{
    public GetProjectNumberCapitalEquipmentRequestValidator()
    {
    }
}
