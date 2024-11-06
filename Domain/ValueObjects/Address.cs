namespace Domain.ValueObjects;

/// <summary>
/// Класс, представляющий адрес.
/// </summary>
public class Address : BaseValueObject
{
    /// <summary>
    /// Пустой конструктор, который может использоваться для создания экземпляра объекта без начальной инициализации.
    /// </summary>
    public Address()
    {
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Address"/> с указанием города, улицы и дома.
    /// </summary>
    /// <param name="city">Город.</param>
    /// <param name="street">Улица.</param>
    /// <param name="house">Номер дома.</param>
    public Address(string city, string street, string house)
    {
        City = city;
        Street = street;
        House = house;
    }

    /// <summary>
    /// Улица.
    /// </summary>
    public string Street { get; private set; }

    /// <summary>
    /// Номер дома.
    /// </summary>
    public string House { get; private set; }

    /// <summary>
    /// Город.
    /// </summary>
    public string City { get; private set; }
}