using Domain.Interface;

namespace Domain.DomainEvents;

public class DrugItemUpdateEvent : IDomainEvent
{
    /// <summary>
    /// Идентификатор DrugItem
    /// </summary>
    public Guid DrugItemId { get; }

    /// <summary>
    /// Новое количество
    /// </summary>
    public double NewAmount { get; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="drugItemId">Идентификатор DrugItem.</param>
    /// <param name="newAmount">Новое кол-во.</param>
    public DrugItemUpdateEvent(Guid drugItemId, double newAmount)
    {
        DrugItemId = drugItemId;
        NewAmount = newAmount;
    }
}