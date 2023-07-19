using FluentValidation;
using MiniBlog.Core.Contracts.Blogs.Queries.GetBlogByBusinessId;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.Blogs.Queries.GetBlogByBusinessId;
public class GetBlogByIdValidator : AbstractValidator<GetBlogByIdQuery>
{
    public GetBlogByIdValidator(ITranslator translator)
    {
        RuleFor(query => query.BlogBusinessId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetBlogByIdQuery.BlogBusinessId)]);
    }
}