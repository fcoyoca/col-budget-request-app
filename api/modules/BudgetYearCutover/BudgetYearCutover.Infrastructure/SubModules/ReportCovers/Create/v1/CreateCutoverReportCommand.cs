using MediatR;

namespace BudgetYearCutover.Infrastructure.SubModules.ReportCovers.Create.v1;

public class CreateCutoverReportCommand : IRequest<CreateCutoverReportResponse>
{
    public List<CutoverReportCommand>? ReportCovers { get; set; } = new();
}

public sealed class CreateCutoverReportResponse
{
    public List<CutoverReportResponse>? ReportCovers { get; set; } = new();
}

public class CutoverReportCommand
{
    public string ReportCoverName { get; set; } = string.Empty;
    public long FileSize { get; set; }
    public string ContentType { get; set; } = string.Empty;
    public string? FileExtension { get; set; }
    public string? Base64Data { get; set; } = string.Empty;
}

public class CutoverReportResponse
{
    public string? ReportCoverName { get; set; }
    public string? RequestPath { get; set; }
    public string? Status { get; set; }
}
