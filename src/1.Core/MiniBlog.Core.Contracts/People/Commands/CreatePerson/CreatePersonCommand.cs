using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniBlog.Core.Contracts.People.Commands.CreatePerson;

public class CreatePersonCommand : ICommand<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}