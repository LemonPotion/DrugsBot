using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public sealed class ProfileValidator : AbstractValidator<Profile>
{
    public ProfileValidator()
    {
        RuleFor(d => d.ExternalId)
            .NotNullOrEmptyWithMessage();
        
        RuleFor(d => d.Email)
            .NotNullOrEmptyWithMessage();
    }
}