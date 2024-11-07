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
            .NotNullOrEmptyWithMessage()
            .Length(2, 150).WithMessage(ValidationMessages.InvalidFormat(nameof(Drug.Name)))
            .Matches(ValidationRegexes.DrugName).WithMessage(ValidationMessages.InvalidFormat(nameof(Drug.Name)));

        RuleFor(d => d.Manufacturer)
            .NotNullOrEmptyWithMessage()
            .Length(2, 100).WithMessage(ValidationMessages.InvalidFormat(nameof(Drug.Manufacturer)))
            .Matches(ValidationRegexes.Manufacturer).WithMessage(ValidationMessages.InvalidFormat(nameof(Drug.Name)));

        RuleFor(d => d.CountryCodeId)
            .NotNullOrEmptyWithMessage()
            .Length(2).WithMessage(ValidationMessages.InvalidFormat(nameof(Drug.CountryCodeId)))
            .Matches(ValidationRegexes.CountryCodeId).WithMessage(ValidationMessages.InvalidFormat(nameof(Drug.Name)));
    }
}