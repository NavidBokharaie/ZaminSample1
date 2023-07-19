using FluentValidation;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.OldTable1s.Queries.GetOldTable1ById;
public class GetOldTable1ByIdValidator : AbstractValidator<GetOldTable1ByIdQuery>
{
    public GetOldTable1ByIdValidator(ITranslator translator)
    {
        RuleFor(query => query.BusinessId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetOldTable1ByIdQuery.BusinessId)]);
    }
}