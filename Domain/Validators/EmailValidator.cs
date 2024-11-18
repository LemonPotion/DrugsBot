using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Validators;

public class EmailValidator : AbstractValidator<Email>
{
    public EmailValidator()
    {
        RuleFor(e => e.Value)
            .NotNullOrEmptyWithMessage()
            .Matches(ValidationRegexes.EmailPattern).WithMessage(ValidationMessages.InvalidFormat(nameof(Email.Value)));
    }
}