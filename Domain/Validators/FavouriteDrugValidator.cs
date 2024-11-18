using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class FavouriteDrugValidator : AbstractValidator<FavoriteDrug>
{
    public FavouriteDrugValidator()
    {
        RuleFor(d => d.ProfileId)
            .NotNullOrEmptyWithMessage();

        RuleFor(d => d.DrugId)
            .NotNullOrEmptyWithMessage();
    }
}