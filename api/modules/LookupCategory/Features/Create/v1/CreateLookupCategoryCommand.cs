using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.LookupCategory.Features.Create.v1;
public record CreateLookupCategoryCommand(
    [property: DefaultValue("Hello World!")] string Name,
    [property: DefaultValue("Important Note.")] string Description) : IRequest<CreateLookupCategoryResponse>;



