using MiniBlog.Core.Domain.People.Events;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.ValueObjects;

namespace MiniBlog.Core.Domain.People.Entities;
public class Person : AggregateRoot
{
    #region Properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    #endregion

    #region Constructors
    private Person()
    {
    }

    private Person(BusinessId businessId, string firstName, string lastName)
    {
        BusinessId = businessId;
        FirstName = firstName;
        LastName = lastName;
        new PersonCreated(businessId.Value, firstName, lastName);
    }
    #endregion

    #region Commands
    public static Person Create(BusinessId businessId, string firstName, string lastName) => new(businessId, firstName, lastName);
    #endregion
}