using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace Core.Contracts.Persons.Commands.CreatePerson;

public class CreatePersonCommand : ICommand<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

}
