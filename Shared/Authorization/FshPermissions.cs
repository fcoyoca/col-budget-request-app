﻿using System.Collections.ObjectModel;

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
        
        //products
        new("View Products", FshActions.View, FshResources.Products, IsBasic: true),
        new("Search Products", FshActions.Search, FshResources.Products, IsBasic: true),
        new("Create Products", FshActions.Create, FshResources.Products),
        new("Update Products", FshActions.Update, FshResources.Products),
        new("Delete Products", FshActions.Delete, FshResources.Products),
        new("Export Products", FshActions.Export, FshResources.Products),

        //brands
        new("View Brands", FshActions.View, FshResources.Brands, IsBasic: true),
        new("Search Brands", FshActions.Search, FshResources.Brands, IsBasic: true),
        new("Create Brands", FshActions.Create, FshResources.Brands),
        new("Update Brands", FshActions.Update, FshResources.Brands),
        new("Delete Brands", FshActions.Delete, FshResources.Brands),
        new("Export Brands", FshActions.Export, FshResources.Brands),

        //todos
        new("View Todos", FshActions.View, FshResources.Todos, IsBasic: true),
        new("Search Todos", FshActions.Search, FshResources.Todos, IsBasic: true),
        new("Create Todos", FshActions.Create, FshResources.Todos),
        new("Update Todos", FshActions.Update, FshResources.Todos),
        new("Delete Todos", FshActions.Delete, FshResources.Todos),
        new("Export Todos", FshActions.Export, FshResources.Todos),
        
        //lookup
        new("View LookupCategories", FshActions.View, FshResources.LookupCategories, IsBasic: true),
        new("Search LookupCategories", FshActions.Search, FshResources.LookupCategories, IsBasic: true),
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
        
        //capital project
        new("View CapitalProjects", FshActions.View, FshResources.CapitalProjects, IsBasic: true),
        new("Search CapitalProjects", FshActions.Search, FshResources.CapitalProjects, IsBasic: true),
        new("Create CapitalProjects", FshActions.Create, FshResources.CapitalProjects),
        new("Update CapitalProjects", FshActions.Update, FshResources.CapitalProjects),
        new("Delete CapitalProjects", FshActions.Delete, FshResources.CapitalProjects),
        new("Export CapitalProjects", FshActions.Export, FshResources.CapitalProjects),
        
        new("Create FileServiceItem", FshActions.Create, FshResources.FileServices),
        new("Budget Year Create Cutover", FshActions.Create, FshResources.BudgetYears),
        new("Budget Year View Cutover", FshActions.View, FshResources.BudgetYears),

         new("View Hangfire", FshActions.View, FshResources.Hangfire),
         new("View Dashboard", FshActions.View, FshResources.Dashboard),

        //audit
        new("View Audit Trails", FshActions.View, FshResources.AuditTrails),
    ];

    public static IReadOnlyList<FshPermission> All { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions);
    public static IReadOnlyList<FshPermission> Root { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<FshPermission> Admin { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<FshPermission> Basic { get; } = new ReadOnlyCollection<FshPermission>(AllPermissions.Where(p => p.IsBasic).ToArray());
}

public record FshPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource)
    {
        return $"Permissions.{resource}.{action}";
    }
}


