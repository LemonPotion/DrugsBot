using Domain.Entities;
using FluentAssertions;
using FluentValidation;

namespace Domain.Tests;

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
        var drugs = _dataGenerator.GenerateDrugs(_dataGenerator.GenerateCountries(3), 5);
        var drugStores = _dataGenerator.GenerateDrugStores(3);
        var testData = _dataGenerator.GenerateDrugItems(drugs, drugStores, 1).First();

        //Act
        Action action = () => new DrugItem(testData.DrugId, testData.DrugStoreId, testData.Count, testData.Cost);

        //Assert
        action.Should().NotThrow<ValidationException>();
    }
    
}