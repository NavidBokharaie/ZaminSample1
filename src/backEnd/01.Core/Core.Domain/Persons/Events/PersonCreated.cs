using Zamin.Core.Domain.Events;

namespace Core.Domain.Persons.Events;
public class PersonCreated : IDomainEvent
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public PersonCreated(
        int id, 
        string firstName,
        string lastName,
        int age
        )
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;

    }
}
