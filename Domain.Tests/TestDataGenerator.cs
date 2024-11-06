using Bogus;
using Domain.Entities;
using Address = Domain.ValueObjects.Address;

namespace Domain.Tests;

public class TestDataGenerator
{
    private readonly Faker<Address> _addressFaker;
    private readonly Faker<Country> _countryFaker;
    private readonly Faker<DrugStore> _drugStoreFaker;

    public TestDataGenerator()
    {
        _addressFaker = new Faker<Address>()
            .RuleFor(a => a.City, f => f.Address.City())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.House, f => f.Random.Int().ToString());

        _countryFaker = new Faker<Country>()
            .RuleFor(d => d.Id, f => f.Random.Guid())
            .RuleFor(c => c.Name, f => f.Address.Country())
            .RuleFor(c => c.CountryCode, f => f.Address.CountryCode());

        _drugStoreFaker = new Faker<DrugStore>()
            .RuleFor(d => d.Id, f => f.Random.Guid())
            .RuleFor(ds => ds.DrugNetwork, f => f.Company.CompanyName())
            .RuleFor(ds => ds.Name, f => f.Company.CompanyName())
            .RuleFor(ds => ds.Number, f => f.Random.Int(1, 100))
            .RuleFor(ds => ds.Address, f => _addressFaker.Generate())
            .RuleFor(ds => ds.PhoneNumber, f => f.Phone.PhoneNumber("+############"));
    }

    public List<Address> GenerateAddresses(int count = 1000)
    {
        return _addressFaker.Generate(count);
    }

    public List<Country> GenerateCountries(int count = 1000)
    {
        return _countryFaker.Generate(count);
    }

    public List<DrugStore> GenerateDrugStores(int count = 1000)
    {
        return _drugStoreFaker.Generate(count);
    }

    public List<Drug> GenerateDrugs(List<Country> countries, int count = 1000)
    {
        var drugFaker = new Faker<Drug>()
            .RuleFor(d => d.Id, f => f.Random.Guid())
            .RuleFor(d => d.Name, f => f.Commerce.ProductName())
            .RuleFor(d => d.Manufacturer, f => f.Company.CompanyName())
            .RuleFor(d => d.CountryCodeId, f => f.Address.CountryCode())
            .RuleFor(d => d.Country, f => f.PickRandom(countries))
            .RuleFor(d => d.Amount, f => f.Random.Int(0, 100));

        return drugFaker.Generate(count);
    }

    public List<DrugItem> GenerateDrugItems(List<Drug> drugs, List<DrugStore> drugStores, int count = 1000)
    {
        var drugItemFaker = new Faker<DrugItem>()
            .RuleFor(di => di.DrugId, f => f.PickRandom(drugs).Id)
            .RuleFor(di => di.DrugStoreId, f => f.PickRandom(drugStores).Id)
            .RuleFor(di => di.Count, f => f.Random.Int(1, 50))
            .RuleFor(di => di.Cost, f => f.Random.Decimal(1, 500));

        return drugItemFaker.Generate(count);
    }
}