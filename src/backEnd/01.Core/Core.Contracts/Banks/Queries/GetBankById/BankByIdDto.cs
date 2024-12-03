namespace Core.Contracts.Banks.Queries.GetBankById;
public class BankByIdDto
{
    public int Id { get; set; }

    public string Name { get; set; }
    public int Code { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }



}
