using FluentValidation;
using Core.Contracts.Banks.Commands;
using Core.Contracts.Banks.Commands.CreateBank;
using Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace Core.ApplicationServices.Banks.Commands.CreateBank;

public class CreateBankValidator : AbstractValidator<CreateBankCommand>
{
    public CreateBankValidator(ITranslator translator, IBankCommandRepository bankCommandRepository)
    {
        /*RuleFor(p => p.FirstName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
        RuleFor(p => p.LastName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}
