using Domain.Entities;
using FluentAssertions;
using FluentValidation;

namespace Domain.Tests.DrugStoreTests;

public class DrugStoreValidationTests
{
    private readonly TestDataGenerator _dataGenerator;

    public DrugStoreValidationTests()
    {
        _dataGenerator = new TestDataGenerator();
    }

    [Fact]
    public void Should_Validate_DrugStore()
    {
        //Arrange
        var testData = _dataGenerator.GenerateDrugStores(1).First();

        //Act
        Action action = () => new DrugStore(testData.DrugNetwork, testData.Name, testData.Number, testData.Address, testData.PhoneNumber);

        //Assert
        action.Should().NotThrow<ValidationException>();
    }
}