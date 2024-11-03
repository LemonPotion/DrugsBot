namespace Domain.Entities;
/// <summary>
/// Страна производителя лекарств.
/// </summary>
public class Country : BaseEntity
{
    /// <summary>
    /// Название страны.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Код страны.
    /// </summary>
    public string CountryCode { get; set; }

    /// <summary>
    /// Навигационное свойство лекарств.
    /// </summary>
    public ICollection<Drug> Drugs { get; set; }
}