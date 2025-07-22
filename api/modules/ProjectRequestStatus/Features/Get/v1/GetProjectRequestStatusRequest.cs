using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
public class GetProjectRequestStatusRequest : IRequest<GetProjectRequestStatusResponse>
{
    public Guid Id { get; set; }
    public GetProjectRequestStatusRequest(Guid id) => Id = id;
}
