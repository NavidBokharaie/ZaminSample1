using FluentValidation;
using Core.Contracts.Persons.Queries.GetPersons;
using Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Persons.Queries.GetPersons;

public class GetPersonValidator : AbstractValidator<GetPersonQuery>
{
    public GetPersonValidator(ITranslator translator)
    {
        //RuleFor(p => p.FirstName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
        //RuleFor(p => p.LastName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
    }
}
