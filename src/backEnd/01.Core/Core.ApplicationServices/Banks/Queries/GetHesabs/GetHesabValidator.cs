using FluentValidation;
using Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;
using Core.Contracts.Banks.Queries.GetHesabs;

namespace Core.ApplicationServices.Banks.Queries.GetHesabs;

public class GetHesabValidator : AbstractValidator<GetHesabQuery>
{
    public GetHesabValidator(ITranslator translator)
    {
        //RuleFor(p => p.FirstName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
        //RuleFor(p => p.LastName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
    }
}
