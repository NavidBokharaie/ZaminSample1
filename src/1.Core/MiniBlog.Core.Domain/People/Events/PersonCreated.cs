using Zamin.Core.Domain.Events;

namespace MiniBlog.Core.Domain.People.Events;
public class PersonCreated : IDomainEvent
{
    public Guid BusinessId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public PersonCreated(Guid businessId, string firstName, string lastName)
    {
        BusinessId = businessId;
        FirstName = firstName;
        LastName = lastName;
    }
}
