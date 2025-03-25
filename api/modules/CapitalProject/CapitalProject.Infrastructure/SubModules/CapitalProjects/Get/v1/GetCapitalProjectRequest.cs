using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public class GetCapitalProjectRequest : IRequest<GetCapitalProjectResponse>
{
    public Guid Id { get; set; }
    public GetCapitalProjectRequest(Guid id) => Id = id;
}
