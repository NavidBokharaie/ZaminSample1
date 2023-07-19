using FluentValidation;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.OldTable1s.Queries.GetOldTable1;

public class GetOldTable1QueryValidator : AbstractValidator<GetOldTable1Query>
{
    public GetOldTable1QueryValidator(ITranslator translator)
    {
        //RuleFor(p => p.FirstName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
        //RuleFor(p => p.LastName).MinimumLength(2).WithMessage(translator[ResourceKeys.InValidMinLengthError]);
    }
}