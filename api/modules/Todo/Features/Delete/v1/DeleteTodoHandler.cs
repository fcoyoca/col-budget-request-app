﻿using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.Todo.Domain;
using budget_request_app.WebApi.Todo.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.Todo.Features.Delete.v1;
public sealed class DeleteTodoHandler(
    ILogger<DeleteTodoHandler> logger,
    [FromKeyedServices("todo")] IRepository<TodoItem> repository)
    : IRequestHandler<DeleteTodoCommand>
{
    public async Task Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var todoItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = todoItem ?? throw new TodoItemNotFoundException(request.Id);
        await repository.DeleteAsync(todoItem, cancellationToken);
        logger.LogInformation("todo with id : {TodoId} deleted", todoItem.Id);
    }
}
