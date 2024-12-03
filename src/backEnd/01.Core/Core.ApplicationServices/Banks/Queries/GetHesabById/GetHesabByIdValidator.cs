using FluentValidation;
using Core.Contracts.Banks.Queries.GetHesabById;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Banks.Queries.GetHesabById;
public class GetHesabByIdValidator : AbstractValidator<GetHesabByIdQuery>
{
    public GetHesabByIdValidator(ITranslator translator)
    {
       /*RuleFor(query => query.Id)
        .NotEmpty().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}
