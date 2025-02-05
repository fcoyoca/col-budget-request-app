using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.Create.v1;
public record CreateLookupValueCommand(
    [property: DefaultValue("Hello World!")] string Name,
    [property: DefaultValue("Important Note.")] Guid LookupCategoryId) : IRequest<CreateLookupValueResponse>;



