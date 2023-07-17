using FluentValidation;
using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.People.Queries.GetPeople;

public class GetPersonQueryValidator : AbstractValidator<GetPersonQuery>
{
    public GetPersonQueryValidator(ITranslator translator)
    {
        //RuleFor(p => p.FirstName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
        //RuleFor(p => p.LastName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
    }
}