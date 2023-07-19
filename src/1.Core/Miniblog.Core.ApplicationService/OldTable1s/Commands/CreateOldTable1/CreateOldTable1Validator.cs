using FluentValidation;
using MiniBlog.Core.Contracts.OldTable1s.Commands;
using MiniBlog.Core.Contracts.OldTable1s.Commands.CreateOldTable1;
using MiniBlog.Core.Domain.Common;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.ApplicationService.OldTable1s.Commands.CreateOldTable1;

public class CreateOldTable1Validator : AbstractValidator<CreateOldTable1Command>
{
    [Obsolete]
    public CreateOldTable1Validator(ITranslator translator, IOldTable1CommandRepository OldTable1CommandRepository)
    {
        CascadeMode = CascadeMode.Stop;
        RuleFor(p => p.FirstName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
        RuleFor(p => p.LastName).NotNull().WithMessage(translator[ResourceKeys.MustNotNullError]);
    }
}