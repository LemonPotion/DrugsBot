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

    /// <summary>
    /// Регулярное выражение для проверки корректности имени.
    /// Формат: только буквы и пробелы, без учета длины.
    /// </summary>
    public static Regex CountryName { get; } = new Regex(@"^[A-Za-zА-Яа-яёЁ\s]+$");

    /// <summary>
    /// Регулярное выражение для проверки корректности кода.
    /// Формат: только заглавные латинские буквы, без учета длины.
    /// </summary>
    public static Regex CountryCode { get; } = new Regex(@"^[A-Z]+$");

    /// <summary>
    /// Регулярное выражение для проверки корректности имени лекарства.
    /// Формат: только буквы, цифры и пробелы, без специальных символов.
    /// </summary>
    public static Regex DrugName { get; } = new Regex(@"^[A-Za-zА-Яа-яёЁ0-9\s]+$");

    /// <summary>
    /// Регулярное выражение для проверки корректности производителя.
    /// Формат: только буквы, пробелы и дефисы.
    /// </summary>
    public static Regex Manufacturer { get; } = new Regex(@"^[A-Za-zА-Яа-яёЁ\s-]+$");

    /// <summary>
    /// Регулярное выражение для проверки корректности кода страны.
    /// Формат: только латинские буквы.
    /// </summary>
    public static Regex CountryCodeId { get; } = new Regex(@"^[A-Za-z]+$");

    /// <summary>
    /// Регулярное выражение для проверки корректности улицы.
    /// Формат: буквы и пробелы.
    /// </summary>
    public static Regex Street { get; } = new Regex(@"^[a-zA-Z\s]+$");

    /// <summary>
    /// Регулярное выражение для проверки корректности города.
    /// Формат: буквы и пробелы.
    /// </summary>
    public static Regex City { get; } = new Regex(@"^[a-zA-Z\s]+$");
    
    /// <summary>
    /// Электронная почта
    /// </summary>
    public static readonly Regex EmailPattern = new (@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
}