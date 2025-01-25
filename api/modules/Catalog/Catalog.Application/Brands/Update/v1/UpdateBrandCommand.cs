using MediatR;

namespace budget_request_app.WebApi.Catalog.Application.Brands.Update.v1;
public sealed record UpdateBrandCommand(
    Guid Id,
    string? Name,
    string? Description = null) : IRequest<UpdateBrandResponse>;
