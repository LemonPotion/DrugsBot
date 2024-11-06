using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

/// <summary>
/// Валидатор для сущности <see cref="DrugItem"/>.
/// Проверяет корректность данных, таких как идентификаторы лекарств и аптек, количество и стоимость.
/// </summary>
public class DrugItemValidator : AbstractValidator<DrugItem>
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="DrugItemValidator"/> и настраивает правила валидации для <see cref="DrugItem"/>.
    /// </summary>
    public DrugItemValidator()
    {
        RuleFor(di => di.DrugId)
            .NotEmpty().WithMessage(ValidationMessages.EmptyException(nameof(DrugItem.DrugId)));

        RuleFor(di => di.DrugStoreId)
            .NotEmpty().WithMessage(ValidationMessages.EmptyException(nameof(DrugItem.DrugStoreId)));

        RuleFor(di => di.Count)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.TooLowValue(nameof(DrugItem.Count)));

        RuleFor(di => di.Cost)
            .GreaterThan(0).WithMessage(ValidationMessages.TooLowValue(nameof(DrugItem.Cost)));
    }
}