namespace budget_request_app.Shared.Authorization;
public static class FshActions
{
    public const string View = nameof(View);
    public const string Search = nameof(Search);
    public const string Create = nameof(Create);
    public const string Update = nameof(Update);
    public const string Delete = nameof(Delete);
    public const string Export = nameof(Export);
    public const string Generate = nameof(Generate);
    public const string Clean = nameof(Clean);
    public const string UpgradeSubscription = nameof(UpgradeSubscription);

    // Add these custom workflow actions:
    public const string Submit = nameof(Submit);
    public const string Approve = nameof(Approve);
    public const string Reject = nameof(Reject);
    public const string Withdraw = nameof(Withdraw);
    public const string Archive = nameof(Archive);
    public const string RequireReview = nameof(RequireReview);
    public const string Unfund = nameof(Unfund); // For "Unfunded Request"
}
