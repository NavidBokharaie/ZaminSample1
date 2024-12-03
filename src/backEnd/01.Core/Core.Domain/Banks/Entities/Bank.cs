using Core.Domain.Banks.Events;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.ValueObjects;

namespace Core.Domain.Banks.Entities;
public class Bank : AggregateRoot<int>
{
    #region Properties
    public string Name { get; private set; }
    public int Code { get; private set; }
    public int UserId { get; private set; }
    public DateTime CreatedDate { get; private set; }


//EntityPropertiesReplacementText
    #endregion

    #region Constructors

    private Bank()
    {
    }

    private Bank(
        string name,
        int code,
        int userId,
        DateTime createdDate
    )
    {
        Name = name;
        Code = code;
        UserId = userId;
        CreatedDate = createdDate;

        AddEvent(new BankCreated(
            Id,
            name,
            code,
            userId,
            createdDate
        ));
    }
    #endregion

    #region Commands
    public static Bank Create(
        string name,
        int code,
        int userId,
        DateTime createdDate
        ) => new(
            name,
            code,
            userId,
            createdDate
        );
    #endregion

//EntityMethodsReplacementText
}
