using Domain.Entities;
using FluentAssertions;
using FluentValidation;

namespace Domain.Tests;

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
        var countries = _dataGenerator.GenerateCountries(3); // Для этого примера мы генерируем несколько стран
        var testData = _dataGenerator.GenerateDrugs(countries, 1).First();

        //Act
        Action action = () => new Drug(testData.Name, testData.Manufacturer, testData.CountryCodeId, testData.Country, testData.Amount);

        //Assert
        action.Should().NotThrow<ValidationException>();
    }
}