using Domain.Validators;
using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Entities;

/// <summary>
/// Сущность аптеки.
/// </summary>
public class DrugStore : BaseEntity<DrugStore>
{
    /// <summary>
    /// Пустой конструктор, который может использоваться для создания экземпляра объекта без начальной инициализации.
    /// </summary>
    public DrugStore()
    {
    }

    /// <summary>
    /// Конструктор, который инициализирует новый объект <see cref="DrugStore"/> с указанными значениями для сети аптеки, имени, номера,
    /// адреса и номера телефона. Также выполняется валидация данных с помощью <see cref="DrugStoreValidator"/>.
    /// </summary>
    /// <param name="drugNetwork">Сеть аптек, к которой принадлежит этот магазин.</param>
    /// <param name="name">Название аптеки.</param>
    /// <param name="number">Номер аптеки (например, номер филиала).</param>
    /// <param name="address">Адрес аптеки.</param>
    /// <param name="phoneNumber">Номер телефона аптеки.</param>
    /// <exception cref="ValidationException">Выбрасывается, если данные не проходят валидацию.</exception>
    public DrugStore(string drugNetwork, string name, int number, Address address, string phoneNumber)
    {
        DrugNetwork = drugNetwork;
        Name = name;
        Number = number;
        Address = address;
        PhoneNumber = phoneNumber;

        ValidateEntity(new DrugStoreValidator());
    }

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

    /// <summary>
    /// Навигационное свойство DrugItem
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; private set; } = new List<DrugItem>();
}