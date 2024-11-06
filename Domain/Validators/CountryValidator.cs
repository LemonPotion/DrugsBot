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
            .NotNullOrEmptyWithMessage(nameof(Country.Name))
            .MaximumLength(100).WithMessage(ValidationMessages.TooHighValue(nameof(Country.Name)));

        RuleFor(c => c.CountryCode)
            .NotNullOrEmptyWithMessage(nameof(Country.CountryCode))
            .Length(2).WithMessage(ValidationMessages.InvalidFormat(nameof(Country.CountryCode)));

        RuleFor(c => c.Drugs)
            .NotNull().WithMessage(ValidationMessages.NullException(nameof(Country.Drugs)));
    }
}