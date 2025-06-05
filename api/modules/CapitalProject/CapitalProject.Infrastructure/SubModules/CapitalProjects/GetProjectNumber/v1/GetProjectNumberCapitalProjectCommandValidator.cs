using budget_request_app.WebApi.CapitalProject.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.GetProjectNumber.v1;
public class GetProjectNumberCapitalProjectCommandValidator : AbstractValidator<GetProjectNumberCapitalProjectRequest>
{
    public GetProjectNumberCapitalProjectCommandValidator(
    )
    {
    }
}
