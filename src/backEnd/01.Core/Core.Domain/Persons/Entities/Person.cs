using Core.Domain.Persons.Events;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.ValueObjects;

namespace Core.Domain.Persons.Entities;
public class Person : AggregateRoot<int>
{
    #region Properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }


//EntityPropertiesReplacementText
    #endregion

    #region Constructors

    private Person()
    {
    }

    private Person(
        string firstName,
        string lastName,
        int age
    )
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;

        AddEvent(new PersonCreated(
            Id,
            firstName,
            lastName,
            age
        ));
    }
    #endregion

    #region Commands
    public static Person Create(
        string firstName,
        string lastName,
        int age
        ) => new(
            firstName,
            lastName,
            age
        );
    #endregion

//EntityMethodsReplacementText
}
