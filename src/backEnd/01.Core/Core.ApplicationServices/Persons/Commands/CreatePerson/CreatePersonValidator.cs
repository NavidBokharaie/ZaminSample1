using FluentValidation;
using Core.Contracts.Persons.Commands;
using Core.Contracts.Persons.Commands.CreatePerson;
using Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Persons.Commands.CreatePerson;

public class CreatePersonValidator : AbstractValidator<CreatePersonCommand>
{
    public CreatePersonValidator(ITranslator translator, IPersonCommandRepository personCommandRepository)
    {
        /*RuleFor(p => p.FirstName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
        RuleFor(p => p.LastName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}
