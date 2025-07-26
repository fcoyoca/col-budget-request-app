using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Get.v1;
public class GetLookupValueRequest : IRequest<GetLookupValueResponse>
{
    public Guid Id { get; set; }
    public GetLookupValueRequest(Guid id) => Id = id;
}
