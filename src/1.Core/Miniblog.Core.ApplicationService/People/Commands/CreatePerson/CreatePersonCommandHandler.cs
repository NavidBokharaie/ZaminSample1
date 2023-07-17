using MiniBlog.Core.Contracts.People.Commands;
using MiniBlog.Core.Contracts.People.Commands.CreatePerson;
using MiniBlog.Core.Domain.People.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.People.Commands.CreatePerson;
public class CreatePersonCommandHandler : CommandHandler<CreatePersonCommand, Guid>
{
    public IPersonCommandRepository _personCommandRepository { get; set; }
    public CreatePersonCommandHandler(ZaminServices zaminServices, IPersonCommandRepository personCommandRepository) : base(zaminServices)
    {
        _personCommandRepository = personCommandRepository;
    }

    public override async Task<CommandResult<Guid>> Handle(CreatePersonCommand createPersonCommand)
    {
        var businessId = Guid.NewGuid();
        Person person = Person.Create(
            businessId,
            createPersonCommand.FirstName,
            createPersonCommand.LastName
        );
        await _personCommandRepository.InsertAsync(person);
        await _personCommandRepository.CommitAsync();
        return await OkAsync(businessId);
    }
}