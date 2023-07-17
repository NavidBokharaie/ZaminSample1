using FluentValidation;
using MiniBlog.Core.Contracts.People.Commands;
using MiniBlog.Core.Contracts.People.Commands.CreatePerson;
using MiniBlog.Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.People.Commands.CreatePerson;

public class CreatePersonValidator : AbstractValidator<CreatePersonCommand>
{
    [Obsolete]
    public CreatePersonValidator(ITranslator translator, IPersonCommandRepository personCommandRepository)
    {
        this.CascadeMode = CascadeMode.Stop;
        RuleFor(p => p.FirstName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
        RuleFor(p => p.LastName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
    }
}