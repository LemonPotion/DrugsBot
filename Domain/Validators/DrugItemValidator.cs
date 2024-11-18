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
        RuleFor(di => di.Amount)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.TooLowValue(nameof(DrugItem.Amount)))
            .LessThanOrEqualTo(10000);

        RuleFor(di => di.Cost)
            .GreaterThan(0).WithMessage(ValidationMessages.TooLowValue(nameof(DrugItem.Cost)))
            .PrecisionScale(10, 2, true).WithMessage(ValidationMessages.InvalidFormat(nameof(DrugItem.Cost)));
    }
}