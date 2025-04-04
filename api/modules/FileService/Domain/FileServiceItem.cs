using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.FileService.Domain;
public class FileServiceItem : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? FileName { get; set; }
    
    public static FileServiceItem Create(string name, string fileName)
    {
        var item = new FileServiceItem();

        item.Name = name;
        item.FileName = fileName;

        return item;
    }
}
