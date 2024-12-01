using Core.Contracts.Persons.Commands;
using Core.Contracts.Persons.Commands.CreatePerson;
using Core.Domain.Persons.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace Core.ApplicationServices.Persons.Commands.CreatePerson;
public class CreatePersonCommandHandler : CommandHandler<CreatePersonCommand, int>
{
    private readonly IPersonCommandRepository _personCommandRepository;
    public CreatePersonCommandHandler(ZaminServices zaminServices, IPersonCommandRepository personCommandRepository) : base(zaminServices)
    {
        _personCommandRepository = personCommandRepository;
    }

    public override async Task<CommandResult<int>> Handle(CreatePersonCommand createPersonCommand)
    {
        Person person = Person.Create(
            createPersonCommand.FirstName,
            createPersonCommand.LastName,
            createPersonCommand.Age
        );
        await _personCommandRepository.InsertAsync(person);
        await _personCommandRepository.CommitAsync();
        return await OkAsync(person.Id);
    }
}
