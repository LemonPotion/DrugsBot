using Domain.Validators;
using FluentValidation.Validators;

namespace Domain.ValueObjects;

public sealed class Email : BaseValueObject
{
    /// <summary>
    /// Конструктор электронной почты
    /// </summary>
    /// <param name="value">Электронная почта.</param>
    public Email(string value)
    {
        Value = value;
        
        ValidateValueObject(new EmailValidator());
    }

    /// <summary>
    /// Значение эл. почты
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Возвращает строковое представление адреса.
    /// </summary>
    /// <returns>Строка, представляющая адрес.</returns>
    public override string ToString()
    {
        return Value;
    }
}