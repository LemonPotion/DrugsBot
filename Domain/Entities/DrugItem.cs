namespace Domain.Entities;

public class DrugItem : BaseEntity
{
    /// <summary>
    /// Идентификатор лекарства.
    /// </summary>
    public Guid DrugId { get; set; }

    /// <summary>
    /// Навигационное свойство лекарства.
    /// </summary>
    public Drug Drug { get; set; }

    /// <summary>
    /// Идентификатор аптеки.
    /// </summary>
    public Guid DrugStoreId { get; set; }

    /// <summary>
    /// Навигационное свойство аптеки.
    /// </summary>
    public DrugStore DrugStore { get; set; }

    /// <summary>
    /// Количество единиц лекарства.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Стоимость одной единицы лекарства.
    /// </summary>
    public decimal Cost { get; set; }
}