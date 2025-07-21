using budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
public class GetProjectRequestGroupRequest : IRequest<GetProjectRequestGroupResponse>
{
    public Guid Id { get; set; }
    public GetProjectRequestGroupRequest(Guid id) => Id = id;
}
