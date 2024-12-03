using Zamin.Core.Domain.Events;

namespace Core.Domain.Banks.Events;
public class BankCreated : IDomainEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Code { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }


    public BankCreated(
        int id, 
        string name,
        int code,
        int userId,
        DateTime createdDate
        )
    {
        Id = id;
        Name = name;
        Code = code;
        UserId = userId;
        CreatedDate = createdDate;

    }
}
