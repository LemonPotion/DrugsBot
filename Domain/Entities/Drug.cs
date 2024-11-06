using Domain.Validators;
using FluentValidation;

namespace Domain.Entities;

/// <summary>
/// Сущность лекарства.
/// </summary>
public class Drug : BaseEntity
{
    /// <summary>
    /// Пустой конструктор, который может использоваться для создания экземпляра объекта без начальной инициализации.
    /// </summary>
    public Drug()
    {
    }

    /// <summary>
    /// Конструктор, который инициализирует новый объект <see cref="Drug"/> с указанными значениями для названия,
    /// производителя, кода страны, страны и количества. Также выполняется валидация данных с помощью <see cref="DrugValidator"/>.
    /// </summary>
    /// <param name="name">Название лекарства.</param>
    /// <param name="manufacturer">Производитель лекарства.</param>
    /// <param name="countryCodeId">Код страны производителя.</param>
    /// <param name="country">Страна, в которой производится лекарство.</param>
    /// <param name="amount">Количество лекарства в наличии.</param>
    /// <exception cref="ValidationException">Выбрасывается, если данные не проходят валидацию.</exception>
    public Drug(string name, string manufacturer, string countryCodeId, Country country, int amount)
    {
        Name = name;
        Manufacturer = manufacturer;
        CountryCodeId = countryCodeId;
        Country = country;
        Amount = amount;

        new DrugValidator().ValidateAndThrow(this);
    }

    /// <summary>
    /// Название лекарства.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Производитель лекарства.
    /// </summary>
    public string Manufacturer { get; private set; }

    /// <summary>
    /// Код страны производителя.
    /// </summary>
    public string CountryCodeId { get; private set; }

    /// <summary>
    /// Навигационное свойство страны производителя.
    /// </summary>
    public Country Country { get; private set; }

    /// <summary>
    /// Количество.
    /// </summary>
    public int Amount { get; private set; }

    /// <summary>
    /// Навигационное свойство DrugItem
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; private set; } = new List<DrugItem>();
}