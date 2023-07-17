using FluentValidation;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.People.Queries.GetPersonByBusinessId;
public class GetPersonByBusinessIdValidator : AbstractValidator<GetPersonByIdQuery>
{
    public GetPersonByBusinessIdValidator(ITranslator translator)
    {
        RuleFor(query => query.BusinessId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetPersonByIdQuery.BusinessId)]);
    }
}