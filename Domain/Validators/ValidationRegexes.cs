using System.Text.RegularExpressions;

namespace Domain.Validators;

/// <summary>
/// Класс, содержащий регулярные выражения для валидации различных данных.
/// </summary>
public static class ValidationRegexes
{
    /// <summary>
    /// Регулярное выражение для проверки корректности телефонного номера.
    /// Формат: международный номер, начинающийся с символа '+', за которым следуют цифры (от 2 до 15 символов).
    /// Пример корректного номера: +1234567890, +1(234)567-890.
    /// </summary>
    public static Regex PhoneNumber { get; } = new Regex(@"^\+?[1-9]\d{1,14}$");
}