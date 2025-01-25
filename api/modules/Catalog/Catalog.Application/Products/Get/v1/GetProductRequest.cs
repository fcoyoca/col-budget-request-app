using MediatR;

namespace budget_request_app.WebApi.Catalog.Application.Products.Get.v1;
public class GetProductRequest : IRequest<ProductResponse>
{
    public Guid Id { get; set; }
    public GetProductRequest(Guid id) => Id = id;
}
