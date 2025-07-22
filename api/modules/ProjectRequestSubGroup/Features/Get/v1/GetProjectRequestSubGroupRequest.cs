using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
public class GetProjectRequestSubGroupRequest : IRequest<GetProjectRequestSubGroupResponse>
{
    public Guid Id { get; set; }
    public GetProjectRequestSubGroupRequest(Guid id) => Id = id;
}
