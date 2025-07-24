using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
public class GetProjectBudgetIntroSectionOutlineItemRequest : IRequest<GetProjectBudgetIntroSectionOutlineItemResponse>
{
    public Guid Id { get; set; }
    public GetProjectBudgetIntroSectionOutlineItemRequest(Guid id) => Id = id;
}
