using Core.Contracts.Banks.Commands;
using Core.Contracts.Banks.Commands.AddHesab;
using FluentValidation;

namespace Core.ApplicationServices.Banks.Commands.AddHesab;

public class AddHesabValidator : AbstractValidator<AddHesabCommand>
{
    public AddHesabValidator(ITranslator translator, IBankCommandRepository bankCommandRepository)
    {
        /*RuleFor(p => p.FirstName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
        RuleFor(p => p.LastName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}
