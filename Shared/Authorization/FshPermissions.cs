using System.Collections.ObjectModel;


namespace budget_request_app.Shared.Authorization;

public static class FshPermissions
{
    private static readonly FshPermission[] AllPermissions =
    [     
        //tenants
        new("View Tenants", FshActions.View, FshResources.Tenants, IsRoot: true),
        new("Create Tenants", FshActions.Create, FshResources.Tenants, IsRoot: true),
        new("Update Tenants", FshActions.Update, FshResources.Tenants, IsRoot: true),
        new("Upgrade Tenant Subscription", FshActions.UpgradeSubscription, FshResources.Tenants, IsRoot: true),

        //identity
        new("View Users", FshActions.View, FshResources.Users),
        new("Search Users", FshActions.Search, FshResources.Users),
        new("Create Users", FshActions.Create, FshResources.Users),
        new("Update Users", FshActions.Update, FshResources.Users),
        new("Delete Users", FshActions.Delete, FshResources.Users),
        new("Export Users", FshActions.Export, FshResources.Users),
        new("View UserRoles", FshActions.View, FshResources.UserRoles),
        new("Update UserRoles", FshActions.Update, FshResources.UserRoles),
        new("View Roles", FshActions.View, FshResources.Roles),
        new("Create Roles", FshActions.Create, FshResources.Roles),
        new("Update Roles", FshActions.Update, FshResources.Roles),
        new("Delete Roles", FshActions.Delete, FshResources.Roles),
        new("View RoleClaims", FshActions.View, FshResources.RoleClaims),
        new("Update RoleClaims", FshActions.Update, FshResources.RoleClaims),

        new("View Hangfire", FshActions.View, FshResources.Hangfire),
        new("View Dashboard", FshActions.View, FshResources.Dashboard),
        
        //lookup
        new("View LookupCategories", FshActions.View, FshResources.LookupCategories),
        new("Search LookupCategories", FshActions.Search, FshResources.LookupCategories),
        new("Create LookupCategories", FshActions.Create, FshResources.LookupCategories),
        new("Update LookupCategories", FshActions.Update, FshResources.LookupCategories),
        new("Delete LookupCategories", FshActions.Delete, FshResources.LookupCategories),
        new("Export LookupCategories", FshActions.Export, FshResources.LookupCategories),
        
        //capital equipment
        new("View CapitalEquipments", FshActions.View, FshResources.CapitalEquipments, IsBasic: true),
        new("Search CapitalEquipments", FshActions.Search, FshResources.CapitalEquipments, IsBasic: true),
        new("Create CapitalEquipments", FshActions.Create, FshResources.CapitalEquipments),
        new("Update CapitalEquipments", FshActions.Update, FshResources.CapitalEquipments),
        new("Delete CapitalEquipments", FshActions.Delete, FshResources.CapitalEquipments),
        new("Export CapitalEquipments", FshActions.Export, FshResources.CapitalEquipments),

        // Workflow for Capital Equipments
        new("Submit CapitalEquipments", FshActions.Submit, FshResources.CapitalEquipments),
        new("Approve CapitalEquipments", FshActions.Approve, FshResources.CapitalEquipments),
        new("Reject CapitalEquipments", FshActions.Reject, FshResources.CapitalEquipments),
        new("Withdraw CapitalEquipments", FshActions.Withdraw, FshResources.CapitalEquipments),
        new("Archive CapitalEquipments", FshActions.Archive, FshResources.CapitalEquipments),
        new("Require Department Review (Equipments)", FshActions.RequireReview, FshResources.CapitalEquipments),
        new("Mark CapitalEquipment as Unfunded", FshActions.Unfund, FshResources.CapitalEquipments),
        
        //capital project
        new("View CapitalProjects", FshActions.View, FshResources.CapitalProjects, IsBasic: true),
        new("Search CapitalProjects", FshActions.Search, FshResources.CapitalProjects, IsBasic: true),
        new("Create CapitalProjects", FshActions.Create, FshResources.CapitalProjects),
        new("Update CapitalProjects", FshActions.Update, FshResources.CapitalProjects),
        new("Delete CapitalProjects", FshActions.Delete, FshResources.CapitalProjects),
        new("Export CapitalProjects", FshActions.Export, FshResources.CapitalProjects),

        // Workflow for Capital Projects
        new("Submit CapitalProjects", FshActions.Submit, FshResources.CapitalProjects),
        new("Approve CapitalProjects", FshActions.Approve, FshResources.CapitalProjects),
        new("Reject CapitalProjects", FshActions.Reject, FshResources.CapitalProjects),
        new("Withdraw CapitalProjects", FshActions.Withdraw, FshResources.CapitalProjects),
        new("Archive CapitalProjects", FshActions.Archive, FshResources.CapitalProjects),
        new("Require Department Review (Projects)", FshActions.RequireReview, FshResources.CapitalProjects),
        new("Mark CapitalProject as Unfunded", FshActions.Unfund, FshResources.CapitalProjects),


        new("Create FileServiceItem", FshActions.Create, FshResources.FileServices),
        new("Budget Year Create Cutover", FshActions.Create, FshResources.BudgetYears),
        new("Budget Year View Cutover", FshActions.View, FshResources.BudgetYears),

        new("View Finance Reports", FshActions.View, FshResources.FinancialReports),

        new("Create cutover process", FshActions.Create, FshResources.Cutover),

        //audit
        new("View Audit Trails", FshActions.View, FshResources.AuditTrails),
    ];

    public static IReadOnlyList<FshPermission> All { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions);
    public static IReadOnlyList<FshPermission> Root { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<FshPermission> Admin { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<FshPermission> Basic { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions.Where(p => p.IsBasic).ToArray());

    private static FshPermission Get(string action, string resource) =>
    All.First(p => p.Action == action && p.Resource == resource);

    public static IReadOnlyList<FshPermission> DepartmentUser => new ReadOnlyCollection<FshPermission>([
        // Capital Equipment Permissions
        Get(FshActions.View, FshResources.CapitalEquipments),
        Get(FshActions.Search, FshResources.CapitalEquipments),
        Get(FshActions.Create, FshResources.CapitalEquipments),
        Get(FshActions.Update, FshResources.CapitalEquipments),
        Get(FshActions.Withdraw, FshResources.CapitalEquipments),
        Get(FshActions.Submit, FshResources.CapitalEquipments),

        // Capital Project Permissions (same request, but different view)
        Get(FshActions.View, FshResources.CapitalProjects),
        Get(FshActions.Search, FshResources.CapitalProjects),
        Get(FshActions.Create, FshResources.CapitalProjects),
        Get(FshActions.Update, FshResources.CapitalProjects),
        Get(FshActions.Withdraw, FshResources.CapitalProjects),
        Get(FshActions.Submit, FshResources.CapitalProjects),
    ]);


    public static IReadOnlyList<FshPermission> FinanceApprover => new ReadOnlyCollection<FshPermission>([
        // Capital Equipments
        Get(FshActions.View, FshResources.CapitalEquipments),
        Get(FshActions.Create, FshResources.CapitalEquipments),
        Get(FshActions.Update, FshResources.CapitalEquipments),
        Get(FshActions.Search, FshResources.CapitalEquipments),
        Get(FshActions.Approve, FshResources.CapitalEquipments),
        Get(FshActions.Reject, FshResources.CapitalEquipments),
        Get(FshActions.Archive, FshResources.CapitalEquipments),
        Get(FshActions.Unfund, FshResources.CapitalEquipments),
        Get(FshActions.RequireReview, FshResources.CapitalEquipments),

        // Capital Project Permissions (same data, different view)
        Get(FshActions.View, FshResources.CapitalProjects),
        Get(FshActions.Create, FshResources.CapitalProjects),
        Get(FshActions.Update, FshResources.CapitalProjects),
        Get(FshActions.Search, FshResources.CapitalProjects),
        Get(FshActions.Approve, FshResources.CapitalProjects),
        Get(FshActions.Reject, FshResources.CapitalProjects),
        Get(FshActions.Archive, FshResources.CapitalProjects),
        Get(FshActions.Unfund, FshResources.CapitalProjects),
        Get(FshActions.RequireReview, FshResources.CapitalProjects)
    ]);


    public static IReadOnlyList<FshPermission> FinanceAdmin => new ReadOnlyCollection<FshPermission>([
        // Core capital project permissions
        Get(FshActions.View, FshResources.CapitalProjects),
        Get(FshActions.Create, FshResources.CapitalProjects),
        Get(FshActions.Search, FshResources.CapitalProjects),
        Get(FshActions.Update, FshResources.CapitalProjects),
        Get(FshActions.Delete, FshResources.CapitalProjects),
        Get(FshActions.Export, FshResources.CapitalProjects),
        // Workflow permissions
        Get(FshActions.Approve, FshResources.CapitalProjects),
        Get(FshActions.Reject, FshResources.CapitalProjects),
        Get(FshActions.Archive, FshResources.CapitalProjects),
        Get(FshActions.RequireReview, FshResources.CapitalProjects),
        Get(FshActions.Unfund, FshResources.CapitalProjects),

        // Capital equipment permissions
        Get(FshActions.View, FshResources.CapitalEquipments),
        Get(FshActions.Search, FshResources.CapitalEquipments),
        Get(FshActions.Create, FshResources.CapitalEquipments),
        Get(FshActions.Update, FshResources.CapitalEquipments),
        Get(FshActions.Delete, FshResources.CapitalEquipments),
        Get(FshActions.Export, FshResources.CapitalEquipments),
        // Workflow permissions
        Get(FshActions.Approve, FshResources.CapitalEquipments),
        Get(FshActions.Reject, FshResources.CapitalEquipments),
        Get(FshActions.Archive, FshResources.CapitalEquipments),
        Get(FshActions.RequireReview, FshResources.CapitalEquipments),
        Get(FshActions.Unfund, FshResources.CapitalEquipments),

        // Reporting
        Get(FshActions.View, FshResources.FinancialReports),

        // Budget year permissions
        Get(FshActions.View, FshResources.BudgetYears),
        Get(FshActions.Create, FshResources.BudgetYears),

        // Optional: View audit or dashboard
        Get(FshActions.View, FshResources.AuditTrails),
        Get(FshActions.View, FshResources.Dashboard),

        // Annual Cutover
        Get(FshActions.Create, FshResources.Cutover),

        // Lookup categories
        Get(FshActions.View, FshResources.LookupCategories),
        Get(FshActions.Search, FshResources.LookupCategories),
        Get(FshActions.Delete, FshResources.LookupCategories),
        Get(FshActions.Create, FshResources.LookupCategories),
        Get(FshActions.Update, FshResources.LookupCategories),
    ]);
}

public record FshPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource)
    {
        return $"Permissions.{resource}.{action}";
    }
}
