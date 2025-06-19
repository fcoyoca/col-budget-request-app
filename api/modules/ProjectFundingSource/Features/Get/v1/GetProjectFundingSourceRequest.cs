using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
public class GetProjectFundingSourceRequest : IRequest<GetProjectFundingSourceResponse>
{
    public Guid Id { get; set; }
    public GetProjectFundingSourceRequest(Guid id) => Id = id;
}
