using Domain.Validators;
using FluentValidation;

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
    /// Инициализирует новый экземпляр класса <see cref="Address"/> с указанием города, улицы, номера дома, почтового кода и кода страны.
    /// </summary>
    /// <param name="city">Город.</param>
    /// <param name="street">Улица.</param>
    /// <param name="postalCode">Почтовый код.</param>
    /// <param name="countryCode">Код страны.</param>
    public Address(string city, string street, int postalCode, string countryCode)
    {
        City = city;
        Street = street;
        PostalCode = postalCode;
        CountryCode = countryCode;

        new AddressValidator().ValidateAndThrow(this);
    }

    /// <summary>
    /// Улица.
    /// </summary>
    public string Street { get; private set; }

    /// <summary>
    /// Почтовый код
    /// </summary>
    public int PostalCode { get; private set; }

    /// <summary>
    /// Код страны в формате ISO
    /// </summary>
    public string CountryCode { get; private set; }

    /// <summary>
    /// Город.
    /// </summary>
    public string City { get; private set; }
}