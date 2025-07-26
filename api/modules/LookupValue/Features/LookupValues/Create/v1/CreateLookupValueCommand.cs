using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Create.v1;
public record CreateLookupValueCommand(
    [property: DefaultValue("Hello World!")] string Name,
    Guid LookupCategoryId) : IRequest<CreateLookupValueResponse>;



