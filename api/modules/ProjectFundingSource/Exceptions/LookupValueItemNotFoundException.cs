using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.ProjectFundingSource.Exceptions;
internal sealed class ProjectFundingSourceItemNotFoundException : NotFoundException
{
    public ProjectFundingSourceItemNotFoundException(Guid id)
        : base($"ProjectFundingSource item with id {id} not found")
    {
    }
}
