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
            .NotEmpty().WithMessage(ValidationMessages.EmptyException(nameof(DrugStore.DrugNetwork)))
            .MaximumLength(100).WithMessage(ValidationMessages.InvalidFormat(nameof(DrugStore.DrugNetwork)));

        RuleFor(ds => ds.Name)
            .NotEmpty().WithMessage(ValidationMessages.EmptyException(nameof(DrugStore.Name)))
            .MaximumLength(100).WithMessage(ValidationMessages.InvalidFormat(nameof(DrugStore.Name)));

        RuleFor(ds => ds.Number)
            .GreaterThan(0).WithMessage(ValidationMessages.TooLowValue(nameof(DrugStore.Number)));

        RuleFor(ds => ds.Address)
            .NotNull().WithMessage(ValidationMessages.NullException(nameof(DrugStore.Address)));

        RuleFor(ds => ds.PhoneNumber)
            .NotEmpty().WithMessage(ValidationMessages.EmptyException(nameof(DrugStore.PhoneNumber)))
            .Matches(ValidationRegexes.PhoneNumber)
            .WithMessage(ValidationMessages.InvalidFormat(nameof(DrugStore.PhoneNumber)));

        RuleFor(ds => ds.DrugItems)
            .NotNull().WithMessage(ValidationMessages.NullException(nameof(DrugStore.DrugItems)));
    }
}