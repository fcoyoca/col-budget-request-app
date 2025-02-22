using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.Catalog.Application.Brands.Create.v1;
public sealed record CreateBrandCommand(
    [property: DefaultValue("Sample Brand")] string? Name,
    [property: DefaultValue("Descriptive Description")] string? Description = null) : IRequest<CreateBrandResponse>;

