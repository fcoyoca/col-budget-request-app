using budget_request_app.WebApi.FileService.Persistence;
using FluentValidation;

namespace budget_request_app.WebApi.FileService.Features.Create.v1;
public class CreateFileServiceValidator : AbstractValidator<CreateFileServiceItemCommand>
{
    public CreateFileServiceValidator(FileServiceDbContext context)
    {
    }
}
