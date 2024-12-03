using FluentValidation;
using Core.Contracts.Banks.Queries.GetBanks;
using Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Banks.Queries.GetBanks;

public class GetBankValidator : AbstractValidator<GetBankQuery>
{
    public GetBankValidator(ITranslator translator)
    {
        //RuleFor(p => p.FirstName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
        //RuleFor(p => p.LastName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
    }
}
