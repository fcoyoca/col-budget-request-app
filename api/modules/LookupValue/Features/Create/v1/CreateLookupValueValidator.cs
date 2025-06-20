﻿using FluentValidation;
using budget_request_app.WebApi.LookupValue.Persistence;

namespace budget_request_app.WebApi.LookupValue.Features.Create.v1;
public class CreateLookupValueValidator : AbstractValidator<CreateLookupValueCommand>
{
    public CreateLookupValueValidator(LookupValueDbContext context)
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.LookupCategoryId).NotEmpty();
    }
}
