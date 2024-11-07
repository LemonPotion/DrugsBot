using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

/// <summary>
/// Валидатор для сущности <see cref="DrugStore"/>.
/// Проверяет корректность данных, таких как сеть аптек, название, номер, адрес, телефон и связанные товары.
/// </summary>
public class DrugStoreValidator : AbstractValidator<DrugStore>
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="DrugStoreValidator"/> и настраивает правила валидации для <see cref="DrugStore"/>.
    /// </summary>
    public DrugStoreValidator()
    {
        RuleFor(ds => ds.DrugNetwork)
            .NotNullOrEmptyWithMessage()
            .Length(2, 100).WithMessage(ValidationMessages.InvalidFormat(nameof(DrugStore.DrugNetwork)));

        RuleFor(ds => ds.Name)
            .NotNullOrEmptyWithMessage()
            .MaximumLength(100).WithMessage(ValidationMessages.InvalidFormat(nameof(DrugStore.Name)));

        RuleFor(ds => ds.Number)
            .GreaterThan(0).WithMessage(ValidationMessages.TooLowValue(nameof(DrugStore.Number)));

        RuleFor(ds => ds.Address)
            .NotNullOrEmptyWithMessage()
            .SetValidator(new AddressValidator());

        RuleFor(ds => ds.PhoneNumber)
            .NotNullOrEmptyWithMessage()
            .Matches(ValidationRegexes.PhoneNumber)
            .WithMessage(ValidationMessages.InvalidFormat(nameof(DrugStore.PhoneNumber)));
    }
}