using FluentValidation;
using MiniBlog.Core.Contracts.Blogs.Queries.GetBlogById;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.Blogs.Queries.GetBlogById;
public class GetBlogByIdValidator : AbstractValidator<GetBlogByIdQuery>
{
    public GetBlogByIdValidator(ITranslator translator)
    {
        RuleFor(query => query.BlogBusinessId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetBlogByIdQuery.BlogBusinessId)]);
    }
}