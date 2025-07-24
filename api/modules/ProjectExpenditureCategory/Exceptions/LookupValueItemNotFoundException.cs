using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Exceptions;
internal sealed class ProjectExpenditureCategoryItemNotFoundException : NotFoundException
{
    public ProjectExpenditureCategoryItemNotFoundException(Guid id)
        : base($"ProjectExpenditureCategory item with id {id} not found")
    {
    }
}
