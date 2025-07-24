using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.ProjectRequestStatus.Exceptions;
internal sealed class ProjectRequestStatusItemNotFoundException : NotFoundException
{
    public ProjectRequestStatusItemNotFoundException(Guid id)
        : base($"ProjectRequestStatus item with id {id} not found")
    {
    }
}
