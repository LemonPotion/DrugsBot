using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

/// <summary>
/// Валидатор для сущности <see cref="Country"/>.
/// Проверяет корректность данных, таких как название страны, код страны и список лекарств.
/// </summary>
public class CountryValidator : AbstractValidator<Country>
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="CountryValidator"/> и настраивает правила валидации для <see cref="Country"/>.
    /// </summary>
    public CountryValidator()
    {
        RuleFor(c => c.Name)
            .NotNullOrEmptyWithMessage()
            .Length(2,100).WithMessage(ValidationMessages.InvalidFormat(nameof(Country.Name)))
            .Matches(ValidationRegexes.CountryName).WithMessage(ValidationMessages.InvalidFormat(nameof(Country.Name)));

        RuleFor(c => c.CountryCode)
            .NotNullOrEmptyWithMessage()
            .Length(2).WithMessage(ValidationMessages.InvalidFormat(nameof(Country.CountryCode)))
            .Matches(ValidationRegexes.CountryCode).WithMessage(ValidationMessages.InvalidFormat(nameof(Country.Name)));
    }
}