using Domain.DomainEvents;
using FluentAssertions;

namespace Domain.Tests.DrugItemEventTests;

public class DrugItemEventPositiveTests
{
    private readonly TestDataGenerator _dataGenerator;

    public DrugItemEventPositiveTests()
    {
        _dataGenerator = new TestDataGenerator();
    }
    
    [Fact]
    public void UpdateDrugAmount_ShouldAddEvent()
    {
        // Arrange
        var generator = new TestDataGenerator();

        var drugItem = generator.GenerateDrugItems(1).First();

        // Act
        drugItem.UpdateDrugAmount(10);
        var domainEvent = drugItem.GetDomainEvents().OfType<DrugItemUpdateEvent>().First();

        // Assert
        domainEvent.NewAmount.Should().Be(10);
        drugItem.GetDomainEvents().Should().ContainItemsAssignableTo<DrugItemUpdateEvent>();
    }
}