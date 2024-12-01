using FluentValidation;
using Core.Contracts.Persons.Queries.GetPersonById;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Persons.Queries.GetPersonById;
public class GetPersonByIdValidator : AbstractValidator<GetPersonByIdQuery>
{
    public GetPersonByIdValidator(ITranslator translator)
    {
       /*RuleFor(query => query.Id)
        .NotEmpty().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}
