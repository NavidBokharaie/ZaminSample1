namespace Core.Domain.Banks.Events;

public class HesabAdded : IDomainEvent
{
    public int Id { get; set; }
    public int HesabNumber { get; set; }
    public string CodeCenter { get; set; }
    public string TelNumber { get; set; }
    public string Address { get; set; }
    public int BankId { get; set; }


    public HesabAdded(
        int id, 
        int hesabNumber,
        string codeCenter,
        string telNumber,
        string address,
        int bankId
        )
    {
        Id = id;
        HesabNumber = hesabNumber;
        CodeCenter = codeCenter;
        TelNumber = telNumber;
        Address = address;
        BankId = bankId;

    }
}
