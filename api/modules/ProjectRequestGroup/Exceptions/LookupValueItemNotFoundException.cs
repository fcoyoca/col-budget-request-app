using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.ProjectRequestGroup.Exceptions;
internal sealed class ProjectRequestGroupItemNotFoundException : NotFoundException
{
    public ProjectRequestGroupItemNotFoundException(Guid id)
        : base($"ProjectRequestGroup item with id {id} not found")
    {
    }
}
