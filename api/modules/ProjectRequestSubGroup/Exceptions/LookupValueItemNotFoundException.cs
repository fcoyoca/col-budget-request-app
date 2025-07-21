using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Exceptions;
internal sealed class ProjectRequestSubGroupItemNotFoundException : NotFoundException
{
    public ProjectRequestSubGroupItemNotFoundException(Guid id)
        : base($"ProjectRequestSubGroup item with id {id} not found")
    {
    }
}
