﻿using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.Catalog.Domain;
using budget_request_app.WebApi.Catalog.Domain.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.Catalog.Application.Products.Delete.v1;
public sealed class DeleteProductHandler(
    ILogger<DeleteProductHandler> logger,
    [FromKeyedServices("catalog:products")] IRepository<Product> repository)
    : IRequestHandler<DeleteProductCommand>
{
    public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var product = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = product ?? throw new ProductNotFoundException(request.Id);
        await repository.DeleteAsync(product, cancellationToken);
        logger.LogInformation("product with id : {ProductId} deleted", product.Id);
    }
}
