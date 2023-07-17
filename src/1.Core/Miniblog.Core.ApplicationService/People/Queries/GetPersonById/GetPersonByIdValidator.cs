using FluentValidation;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.People.Queries.GetPersonById;
public class GetPersonByIdValidator : AbstractValidator<GetPersonByIdQuery>
{
    public GetPersonByIdValidator(ITranslator translator)
    {
        RuleFor(query => query.BusinessId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetPersonByIdQuery.BusinessId)]);
    }
}