using Zamin.Core.Domain.Events;

namespace MiniBlog.Core.Domain.OldTable1s.Events;
public class OldTable1Created : IDomainEvent
{
    public Guid BusinessId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public OldTable1Created(Guid businessId, string firstName, string lastName)
    {
        BusinessId = businessId;
        FirstName = firstName;
        LastName = lastName;
    }
}
