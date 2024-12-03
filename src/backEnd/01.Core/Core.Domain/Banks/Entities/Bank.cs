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



private List<Hesab> _hesabs = new List<Hesab>();
public IReadOnlyCollection<Hesab> Hesabs => _hesabs.ToList();
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


#region Hesabs
public Hesab AddHesab(
        int hesabNumber,
        string codeCenter,
        string telNumber,
        string address,
        int bankId
)
{
    var entity = Hesab.Create(
            hesabNumber,
            codeCenter,
            telNumber,
            address,
            bankId
    );
    _hesabs.Add(entity);
    AddEvent(new HesabAdded(
        entity.Id,
            entity.HesabNumber,
            entity.CodeCenter,
            entity.TelNumber,
            entity.Address,
            entity.BankId
    ));

    return entity;
}
#endregion
//EntityMethodsReplacementText
}
