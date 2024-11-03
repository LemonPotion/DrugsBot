using Domain.ValueObjects;

namespace Domain.Entities;

/// <summary>
/// Сущность аптеки.
/// </summary>
public class DrugStore : BaseEntity
{
    /// <summary>
    /// Название аптечной сети.
    /// </summary>
    public string DrugNetwork { get; set; }

    /// <summary>
    /// Название аптеки.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Номер аптеки.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Адрес аптеки.
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// Номер телефона аптеки.
    /// </summary>
    public string PhoneNumber { get; set; }
}