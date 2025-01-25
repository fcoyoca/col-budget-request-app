using Ardalis.Specification;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.Catalog.Application.Brands.Get.v1;
using budget_request_app.WebApi.Catalog.Domain;

namespace budget_request_app.WebApi.Catalog.Application.Brands.Search.v1;
public class SearchBrandSpecs : EntitiesByPaginationFilterSpec<Brand, BrandResponse>
{
    public SearchBrandSpecs(SearchBrandsCommand command)
        : base(command) =>
        Query
            .OrderBy(c => c.Name, !command.HasOrderBy())
            .Where(b => b.Name.Contains(command.Keyword), !string.IsNullOrEmpty(command.Keyword));
}
