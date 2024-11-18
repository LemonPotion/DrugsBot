using Domain.Validators;
using FluentValidation;

namespace Domain.Entities;

/// <summary>
/// Страна производителя лекарств.
/// </summary>
public class Country : BaseEntity<Country>
{
    /// <summary>
    /// Пустой конструктор, который может использоваться для создания экземпляра объекта без начальной инициализации.
    /// </summary>
    public Country()
    {
    }

    /// <summary>
    /// Конструктор, который инициализирует новый объект <see cref="Country"/> с указанными значениями для названия и кода страны.
    /// Также выполняется валидация данных с помощью <see cref="CountryValidator"/>.
    /// </summary>
    /// <param name="name">Название страны.</param>
    /// <param name="countryCode">Код страны.</param>
    /// <exception cref="ValidationException">Выбрасывается, если данные не проходят валидацию.</exception>
    public Country(string name, string countryCode)
    {
        Name = name;
        CountryCode = countryCode;
        ValidateEntity(new CountryValidator());
    }

    /// <summary>
    /// Название страны.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Код страны.
    /// </summary>
    public string CountryCode { get; private set; }

    /// <summary>
    /// Навигационное свойство лекарств.
    /// </summary>
    public ICollection<Drug> Drugs { get; private set; } = new List<Drug>();
}