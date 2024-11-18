using Domain.Entities;
using FluentAssertions;
using FluentValidation;

namespace Domain.Tests.CountryTests;

public class CountryValidationTests
{
    private readonly TestDataGenerator _dataGenerator;

    public CountryValidationTests()
    {
        _dataGenerator = new TestDataGenerator();
    }

    [Fact]
    public void Should_Validate_Country()
    {
        //Arrange
        var testData = _dataGenerator.GenerateCountries(1).First();

        //Act
        Action action = () => new Country(testData.Name, testData.CountryCode);

        //Assert
        action.Should().NotThrow<ValidationException>();
    }
    
}