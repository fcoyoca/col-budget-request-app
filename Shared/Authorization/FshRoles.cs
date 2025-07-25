using System.Collections.ObjectModel;

namespace budget_request_app.Shared.Authorization;

public static class FshRoles
{
    public const string Admin = nameof(Admin);
    public const string Basic = nameof(Basic);
    public const string FinanceApprover = nameof(FinanceApprover);
    public const string FinanceAdmin = nameof(FinanceAdmin);
    public const string DepartmentUser = nameof(DepartmentUser);

    public static IReadOnlyList<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
    {
        Admin,
        Basic,
        FinanceApprover,
        FinanceAdmin,
        DepartmentUser
    });

    public static bool IsDefault(string roleName) => DefaultRoles.Any(r => r == roleName);
}
