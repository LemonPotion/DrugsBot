using FluentValidation;

namespace Domain.Validators;

/// <summary>
/// Класс расширений для валидации, предоставляющий дополнительные методы для валидаторов.
/// </summary>
public static class ValidationExtensions
{
    /// <summary>
    /// Расширение для проверки, что значение не является <c>null</c> или пустым строковым значением.
    /// Использует специфичные сообщения об ошибке для каждого случая.
    /// </summary>
    /// <typeparam name="T">Тип сущности, на которую применяется валидатор.</typeparam>
    /// <typeparam name="TProperty">Тип свойства, которое валидируется.</typeparam>
    /// <param name="ruleBuilder">Правило валидатора для указанного свойства.</param>
    /// <param name="paramName">Имя проверяемого параметра, которое будет использоваться в сообщении об ошибке.</param>
    /// <returns>Возвращает объект <see cref="IRuleBuilderOptions{T, TProperty}"/>, для дальнейшего построения правила валидации.</returns>
    public static IRuleBuilderOptions<T, TProperty> NotNullOrEmptyWithMessage<T, TProperty>(
        this IRuleBuilder<T, TProperty> ruleBuilder,
        string paramName)
    {
        return ruleBuilder
            .NotNull().WithMessage(ValidationMessages.NullException(paramName)) // Проверка на null
            .NotEmpty().WithMessage(ValidationMessages.EmptyException(paramName)); // Проверка на пустое значение
    }
}