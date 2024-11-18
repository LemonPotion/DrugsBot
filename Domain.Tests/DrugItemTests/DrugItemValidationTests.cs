using Domain.Entities;
using FluentAssertions;
using FluentValidation;

namespace Domain.Tests.DrugItemTests;

public class DrugItemValidationTests
{
    private readonly TestDataGenerator _dataGenerator;

    public DrugItemValidationTests()
    {
        _dataGenerator = new TestDataGenerator();
    }

    [Fact]
    public void Should_Validate_DrugItem()
    {
        //Arrange
        var drugs = _dataGenerator.GenerateDrugs();
        var drugStores = _dataGenerator.GenerateDrugStores();
        var testData = _dataGenerator.GenerateDrugItems(1).First();

        //Act
        Action action = () => new DrugItem(testData.DrugId, testData.DrugStoreId, testData.Amount, testData.Cost);

        //Assert
        action.Should().NotThrow<ValidationException>();
    }
    
}