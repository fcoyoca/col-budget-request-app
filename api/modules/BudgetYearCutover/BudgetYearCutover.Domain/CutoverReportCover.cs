using System.ComponentModel.DataAnnotations;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace BudgetYearCutover.Domain;

public class CutoverReportCover : AuditableEntity, IAggregateRoot
{
    [Required]
    [StringLength(255)]
    public string FileName { get; set; } = string.Empty;

    [Required]
    public long FileSize { get; set; }

    [Required]
    [StringLength(100)]
    public string ContentType { get; set; } = string.Empty;

    [StringLength(10)]
    public string? FileExtension { get; set; }

    [Required]
    [StringLength(1000)]
    public string FilePath { get; set; } = string.Empty;

    [Required]
    [StringLength(1000)]
    public string RequestPath { get; set; } = string.Empty;


    [Required]
    [StringLength(50)]
    public string Status { get; set; } = "Uploaded";

    public static CutoverReportCover Create(string fileName, long fileSize, string contentType, string filePath, string requestPath, string status, string fileExtension)
    {
        var data = new CutoverReportCover();

        data.FileName = fileName;
        data.FileSize = fileSize;
        data.ContentType = contentType;
        data.FilePath = filePath;
        data.Status = status;
        data.RequestPath = requestPath;
        data.FileExtension = fileExtension;

        return data;
    }
}
