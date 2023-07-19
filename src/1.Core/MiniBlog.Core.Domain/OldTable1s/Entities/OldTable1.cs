using MiniBlog.Core.Domain.OldTable1s.Events;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.ValueObjects;

namespace MiniBlog.Core.Domain.OldTable1s.Entities;
public class OldTable1 : AggregateRoot
{
    #region Properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    #endregion

    #region Constructors
    private OldTable1()
    {
    }

    private OldTable1(BusinessId businessId, string firstName, string lastName)
    {
        BusinessId = businessId;
        FirstName = firstName;
        LastName = lastName;
        new OldTable1Created(businessId.Value, firstName, lastName);
    }
    #endregion

    #region Commands
    public static OldTable1 Create(BusinessId businessId, string firstName, string lastName) => new(businessId, firstName, lastName);
    #endregion
}