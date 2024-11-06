namespace Domain.Validators;

/// <summary>
/// Класс, содержащий статические функции для генерации сообщений об ошибках валидации.
/// </summary>
public class ValidationMessages
{
    /// <summary>
    /// Генерация сообщения об ошибке, если параметр имеет значение <c>null</c>.
    /// </summary>
    public static readonly Func<string, string> NullException = param => $"{param} is null";

    /// <summary>
    /// Генерация сообщения об ошибке, если параметр является пустым.
    /// </summary>
    public static readonly Func<string, string> EmptyException = param => $"{param} is empty";

    /// <summary>
    /// Генерация сообщения об ошибке, если дата параметра слишком старая.
    /// </summary>
    public static readonly Func<string, string> OldDateException = param => $"{param} Date is too old";

    /// <summary>
    /// Генерация сообщения об ошибке, если значение параметра слишком низкое.
    /// </summary>
    public static readonly Func<string, string> TooLowValue = param => $"{param} value is too low";

    /// <summary>
    /// Генерация сообщения об ошибке, если значение параметра слишком высокое.
    /// </summary>
    public static readonly Func<string, string> TooHighValue = param => $"{param} value is too high";

    /// <summary>
    /// Генерация сообщения об ошибке, если дата параметра является будущей.
    /// </summary>
    public static readonly Func<string, string> FutureDateException = param => $"{param} Date is future";

    /// <summary>
    /// Генерация сообщения об ошибке, если формат параметра некорректен.
    /// </summary>
    public static readonly Func<string, string> InvalidFormat = param => $"{param} is invalid format";

    /// <summary>
    /// Генерация сообщения об ошибке, если значение параметра является некорректным значением перечисления.
    /// </summary>
    public static readonly Func<string, string> InvalidEnumValue = param => $"{param} Invalid enum value";
}