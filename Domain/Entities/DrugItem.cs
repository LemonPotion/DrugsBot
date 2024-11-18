using Domain.DomainEvents;
using Domain.Validators;
using FluentValidation;

namespace Domain.Entities;

public class DrugItem : BaseEntity<DrugItem>
{
    /// <summary>
    /// Пустой конструктор, который может использоваться для создания экземпляра объекта без начальной инициализации.
    /// </summary>
    public DrugItem()
    {
    }

    /// <summary>
    /// Конструктор, который инициализирует новый объект <see cref="DrugItem"/> с указанными значениями для идентификаторов лекарства и аптеки,
    /// количества и стоимости. Также выполняется валидация данных с помощью <see cref="DrugItemValidator"/>.
    /// </summary>
    /// <param name="drugId">Идентификатор лекарства.</param>
    /// <param name="drugStoreId">Идентификатор аптеки.</param>
    /// <param name="amount">Количество товара в наличии.</param>
    /// <param name="cost">Стоимость товара.</param>
    /// <exception cref="ValidationException">Выбрасывается, если данные не проходят валидацию.</exception>
    public DrugItem(Guid drugId, Guid drugStoreId, double amount, decimal cost)
    {
        DrugId = drugId;
        DrugStoreId = drugStoreId;
        Amount = amount;
        Cost = cost;

        ValidateEntity(new DrugItemValidator());
    }

    /// <summary>
    /// Идентификатор лекарства.
    /// </summary>
    public Guid DrugId { get; private set; }

    /// <summary>
    /// Навигационное свойство лекарства.
    /// </summary>
    public Drug Drug { get; private set; }

    /// <summary>
    /// Идентификатор аптеки.
    /// </summary>
    public Guid DrugStoreId { get; private set; }

    /// <summary>
    /// Навигационное свойство аптеки.
    /// </summary>
    public DrugStore DrugStore { get; private set; }

    /// <summary>
    /// Количество единиц лекарства.
    /// </summary>
    public double Amount { get; private set; }

    /// <summary>
    /// Стоимость одной единицы лекарства.
    /// </summary>
    public decimal Cost { get; private set; }

    public void UpdateDrugAmount(double amount)
    {
        Amount = amount;

        ValidateEntity(new DrugItemValidator());
        
        AddDomainEvent(new DrugItemUpdateEvent(DrugId, amount));
    }
}