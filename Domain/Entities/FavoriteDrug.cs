using Domain.Validators;

namespace Domain.Entities;

public class FavoriteDrug : BaseEntity<FavoriteDrug>
{
    public FavoriteDrug(
        Guid profileId,
        Guid drugId,
        Profile profile,
        Drug drug,
        Guid? drugStoreId = null,
        DrugStore? drugStore = null)
    {
        ProfileId = profileId;
        DrugId = drugId;
        DrugStoreId = drugStoreId;
        Profile = profile;
        Drug = drug;
        DrugStore = drugStore;
        ValidateEntity(new FavouriteDrugValidator());
    }

    /// <summary>
    /// Идентификатор профиля.
    /// </summary>
    public Guid ProfileId { get; private init; }

    /// <summary>
    /// Идентификатор препарата.
    /// </summary>
    public Guid DrugId { get; private set; }

    /// <summary>
    /// Идентификатор аптеки.
    /// </summary>
    public Guid? DrugStoreId { get; private set; }

    // Навигационные свойства
    public Profile Profile { get; private set; }
    public Drug Drug { get; private set; }
    public DrugStore? DrugStore { get; private set; }
}