using BudgetYearCutover.Domain;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Storage;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BudgetYearCutover.Infrastructure.SubModules.ReportCovers.Create.v1;

public sealed class CreateReportCoversHandler(
    IStorageService storageService,
    IConfiguration configuration,
    IHttpContextAccessor httpContextAccessor,
    ILogger<CreateReportCoversHandler> logger,
    [FromKeyedServices("budgetYearCutover")] IRepository<CutoverReportCover> repository,
    IWebHostEnvironment _env
    )
    : IRequestHandler<CreateCutoverReportCommand, CreateCutoverReportResponse>
{
    public async Task<CreateCutoverReportResponse> Handle(CreateCutoverReportCommand request, CancellationToken cancellationToken)
    {
        var response = new CreateCutoverReportResponse();

        var records = await repository.ListAsync(cancellationToken);

        foreach (var report in request.ReportCovers!)
        {
            var exist = records.FindAll(p => p.FileName == report.ReportCoverName);

            if (string.IsNullOrEmpty(report.ReportCoverName)
                || report.FileSize == 0 || string.IsNullOrEmpty(report.ReportCoverName) || string.IsNullOrEmpty(report.FileExtension))
            {
                throw new Exception("Invalid file");
            }

            if (exist!.Count == 0)
            {
                // Remove base64 header prefix
                var base64 = report.Base64Data;
                var commaIndex = base64.IndexOf(',');
                if (commaIndex >= 0)
                    base64 = base64.Substring(commaIndex + 1);

                byte[] fileBytes;
                try
                {
                    fileBytes = Convert.FromBase64String(base64);
                }
                catch
                {
                    throw new("Invalid base64 file data.");
                }

                string relativePath = $"{configuration.GetValue<string>("FileStorage:FileProviderReportCovers")}";
                var rootDrive = Path.GetPathRoot(AppContext.BaseDirectory); // e.g., "D:\", "C:\"
                var fileProviderFullPath = Path.Combine(rootDrive, relativePath);

                // Ensure directory exists
                if (!Directory.Exists(fileProviderFullPath))
                {
                    Directory.CreateDirectory(fileProviderFullPath);
                }

                string folderName = fileProviderFullPath;
                string requestPath = $"{configuration.GetValue<string>("FileStorage:RequestPathReportCovers")}/{report.ReportCoverName}";

                var safeFileName = $"{report.ReportCoverName}";
                var filePath = Path.Combine(fileProviderFullPath, safeFileName);
                var context = httpContextAccessor.HttpContext;
                var originUrl = $"{context.Request.Scheme}://{context.Request.Host}";
            

                await System.IO.File.WriteAllBytesAsync(filePath, fileBytes, cancellationToken: cancellationToken);

                var fileRecord = CutoverReportCover.Create(report.ReportCoverName, report.FileSize, report.ContentType, filePath, requestPath, "Uploaded", report.FileExtension);

                await repository.AddAsync(fileRecord, cancellationToken);

                response.ReportCovers!.Add(new CutoverReportResponse
                {
                    RequestPath = $"{originUrl}{requestPath}",
                    ReportCoverName = report.ReportCoverName,
                    Status = "Uploaded"
                });
            }
            else
            {
                // Update the first existing record and overwrite the file
                var existingReport = exist.First();

                // Remove base64 header prefix
                var base64 = report.Base64Data;
                var commaIndex = base64.IndexOf(',');
                if (commaIndex >= 0)
                    base64 = base64.Substring(commaIndex + 1);

                byte[] fileBytes;
                try
                {
                    fileBytes = Convert.FromBase64String(base64);
                }
                catch
                {
                    throw new("Invalid base64 file data.");
                }

                string relativePath = $"{configuration.GetValue<string>("FileStorage:FileProviderReportCovers")}";
                var rootDrive = Path.GetPathRoot(AppContext.BaseDirectory);
                var fileProviderFullPath = Path.Combine(rootDrive, relativePath);

                // Ensure directory exists
                if (!Directory.Exists(fileProviderFullPath))
                {
                    Directory.CreateDirectory(fileProviderFullPath);
                }

                var safeFileName = $"{report.ReportCoverName}";
                var filePath = Path.Combine(fileProviderFullPath, safeFileName);
                string requestPath = $"{configuration.GetValue<string>("FileStorage:RequestPathReportCovers")}/{report.ReportCoverName}";
                var context = httpContextAccessor.HttpContext;
                var originUrl = $"{context.Request.Scheme}://{context.Request.Host}";
                // Overwrite the file
                await System.IO.File.WriteAllBytesAsync(filePath, fileBytes, cancellationToken: cancellationToken);

                // Update the existing record's properties
                existingReport.FileSize = report.FileSize;
                existingReport.ContentType = report.ContentType;
                existingReport.FilePath = filePath;
                existingReport.RequestPath = requestPath;
                existingReport.Status = "Updated";
                existingReport.FileExtension = report.FileExtension;

                await repository.UpdateAsync(existingReport, cancellationToken);

                response.ReportCovers!.Add(new CutoverReportResponse
                {
                    RequestPath = $"{originUrl}{requestPath}",
                    ReportCoverName = report.ReportCoverName,
                    Status = "Updated"
                });

                logger.LogInformation("Report cover '{ReportCoverName}' updated and file overwritten.", report.ReportCoverName);
            }
        }

        return response;
    }
}
