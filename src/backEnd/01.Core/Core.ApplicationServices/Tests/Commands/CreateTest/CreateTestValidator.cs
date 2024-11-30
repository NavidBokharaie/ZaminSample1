using Core.Contracts.Tests.Commands;
using Core.Contracts.Tests.Commands.CreateTest;
using FluentValidation;

namespace Core.ApplicationServices.Tests.Commands.CreateTest;

public class CreateTestValidator : AbstractValidator<CreateTestCommand>
{
    [Obsolete]
    public CreateTestValidator(ITranslator translator, ITestCommandRepository testCommandRepository)
    {
        CascadeMode = CascadeMode.Stop;
        /*RuleFor(p => p.FirstName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
        RuleFor(p => p.LastName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);*/
    }
}