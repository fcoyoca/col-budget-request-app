using MediatR;

namespace budget_request_app.WebApi.LookupCategory.Features.Get.v1;
public class GetLookupCategoryRequest : IRequest<GetLookupCategoryResponse>
{
    public Guid Id { get; set; }
    public GetLookupCategoryRequest(Guid id) => Id = id;
}
