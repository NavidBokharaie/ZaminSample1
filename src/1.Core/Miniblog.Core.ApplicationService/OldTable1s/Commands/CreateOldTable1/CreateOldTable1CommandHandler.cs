using MiniBlog.Core.Contracts.OldTable1s.Commands;
using MiniBlog.Core.Contracts.OldTable1s.Commands.CreateOldTable1;
using MiniBlog.Core.Domain.OldTable1s.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.OldTable1s.Commands.CreateOldTable1;
public class CreateOldTable1CommandHandler : CommandHandler<CreateOldTable1Command, Guid>
{
    public IOldTable1CommandRepository _OldTable1CommandRepository { get; set; }
    public CreateOldTable1CommandHandler(ZaminServices zaminServices, IOldTable1CommandRepository OldTable1CommandRepository) : base(zaminServices)
    {
        _OldTable1CommandRepository = OldTable1CommandRepository;
    }

    public override async Task<CommandResult<Guid>> Handle(CreateOldTable1Command createOldTable1Command)
    {
        var businessId = Guid.NewGuid();
        OldTable1 OldTable1 = OldTable1.Create(
            businessId,
            createOldTable1Command.FirstName,
            createOldTable1Command.LastName
        );
        await _OldTable1CommandRepository.InsertAsync(OldTable1);
        await _OldTable1CommandRepository.CommitAsync();
        return await OkAsync(businessId);
    }
}