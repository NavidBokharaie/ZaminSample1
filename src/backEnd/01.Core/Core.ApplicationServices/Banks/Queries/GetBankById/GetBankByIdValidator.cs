using FluentValidation;
using Core.Contracts.Banks.Queries.GetBankById;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Banks.Queries.GetBankById;
public class GetBankByIdValidator : AbstractValidator<GetBankByIdQuery>
{
    public GetBankByIdValidator(ITranslator translator)
    {
       /*RuleFor(query => query.Id)
        .NotEmpty().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}
