using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
public class GetProjectExpenditureCategoryRequest : IRequest<GetProjectExpenditureCategoryResponse>
{
    public Guid Id { get; set; }
    public GetProjectExpenditureCategoryRequest(Guid id) => Id = id;
}
