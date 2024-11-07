﻿using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Validators;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(address => address.Street)
            .NotNullOrEmptyWithMessage()
            .Length(3, 100).WithMessage(ValidationMessages.InvalidFormat(nameof(Address.Street)))
            .Matches(ValidationRegexes.Street).WithMessage(ValidationMessages.InvalidFormat(nameof(Address.Street)));

        RuleFor(address => address.City)
            .NotNullOrEmptyWithMessage()
            .Length(2, 50).WithMessage(ValidationMessages.InvalidFormat(nameof(Address.City)))
            .Matches(ValidationRegexes.City).WithMessage(ValidationMessages.InvalidFormat(nameof(Address.City)));

        RuleFor(address => address.PostalCode)
            .NotNullOrEmptyWithMessage()
            .GreaterThanOrEqualTo(11111)
            .LessThanOrEqualTo(999999);
        
        RuleFor(address => address.CountryCode)
            .NotNullOrEmptyWithMessage()
            .Length(2).WithMessage(ValidationMessages.InvalidFormat(nameof(Address.CountryCode)))
            .Matches(ValidationRegexes.CountryCode).WithMessage(ValidationMessages.InvalidFormat(nameof(Address.CountryCode)));
    }
}