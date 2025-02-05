using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.LookupCategory.Exceptions;
internal sealed class LookupCategoryItemNotFoundException : NotFoundException
{
    public LookupCategoryItemNotFoundException(Guid id)
        : base($"lookupcategory item with id {id} not found")
    {
    }
}
