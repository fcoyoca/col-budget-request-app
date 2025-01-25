using FluentValidation;
using budget_request_app.WebApi.Todo.Persistence;

namespace budget_request_app.WebApi.Todo.Features.Create.v1;
public class CreateTodoValidator : AbstractValidator<CreateTodoCommand>
{
    public CreateTodoValidator(TodoDbContext context)
    {
        RuleFor(p => p.Title).NotEmpty();
        RuleFor(p => p.Note).NotEmpty();
    }
}
