using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

/// <summary>
/// Валидатор для сущности <see cref="Drug"/>.
/// Проверяет корректность данных о лекарственном средстве, таких как имя, производитель, код страны, количество и страна происхождения.
/// </summary>
public class DrugValidator : AbstractValidator<Drug>
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="DrugValidator"/> и настраивает правила валидации для <see cref="Drug"/>.
    /// </summary>
    public DrugValidator()
    {
        RuleFor(d => d.Name)
            .NotNullOrEmptyWithMessage(nameof(Drug.Name))
            .MaximumLength(100).WithMessage(ValidationMessages.TooHighValue(nameof(Drug.Name)));

        RuleFor(d => d.Manufacturer)
            .NotNullOrEmptyWithMessage(nameof(Drug.Manufacturer))
            .MaximumLength(100).WithMessage(ValidationMessages.TooHighValue(nameof(Drug.Manufacturer)));

        RuleFor(d => d.CountryCodeId)
            .NotNullOrEmptyWithMessage(nameof(Drug.CountryCodeId))
            .Length(2).WithMessage(ValidationMessages.TooHighValue(nameof(Drug.CountryCodeId)));

        RuleFor(d => d.Country)
            .NotNull().WithMessage(ValidationMessages.NullException(nameof(Drug.Country)));

        RuleFor(d => d.Amount)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.TooLowValue(nameof(Drug.Amount)));
    }
}