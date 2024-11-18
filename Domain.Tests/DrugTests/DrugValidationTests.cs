using Domain.Entities;
using FluentAssertions;
using FluentValidation;

namespace Domain.Tests.DrugTests;

public class DrugValidationTests
{
    private readonly TestDataGenerator _dataGenerator;

    public DrugValidationTests()
    {
        _dataGenerator = new TestDataGenerator();
    }

    [Fact]
    public void Should_Validate_Drug()
    {
        //Arrange
        var testData = _dataGenerator.GenerateDrugs(1).First();

        //Act
        Action action = () => new Drug(testData.Name, testData.Manufacturer, testData.CountryCodeId, testData.Country, testData.Amount);

        //Assert
        action.Should().NotThrow<ValidationException>();
    }
}