using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.Get.v1;
public class GetBudgetYearRequest : IRequest<GetBudgetYearResponse>
{
    public Guid Id { get; set; }
    public GetBudgetYearRequest(Guid id) => Id = id;
}
