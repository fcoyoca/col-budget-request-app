using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public record CreateBudgetYearCommand() : IRequest<CreateBudgetYearResponse>;



