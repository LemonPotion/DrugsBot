using Domain.Validators;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Profile : BaseEntity<Profile>
{
    /// <summary>
    /// Внешний идентификатор (телеграм)
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Электронная почта
    /// </summary>
    public Email Email { get; set; }

    /// <summary>
    /// Список FavouriteDrug у пользователя
    /// </summary>
    public ICollection<FavoriteDrug> FavouriteDrugs { get; set; } = new List<FavoriteDrug>();

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="externalId">Внешний идентификатор (телеграм).</param>
    /// <param name="email">Электронная почта.</param>
    public Profile(
        string externalId,
        Email email)
    {
        ExternalId = externalId;
        Email = email;

        ValidateEntity(new ProfileValidator());
    }
}