namespace Domain.Entities;

/// <summary>
/// Сущность лекарства.
/// </summary>
public class Drug : BaseEntity
{
    /// <summary>
    /// Название лекарства.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Производитель лекарства.
    /// </summary>
    public string Manufacturer { get; set; }

    /// <summary>
    /// Код страны производителя.
    /// </summary>
    public string CountryCodeId { get; set; }

    /// <summary>
    /// Навигационное свойство страны производителя.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// Количество.
    /// </summary>
    public int Amount { get; set; }
}