namespace Core.Contracts.Banks.Queries.GetHesabs;
public class HesabDto
{
    public int Id { get; set; }

    public int HesabNumber { get; set; }
    public string CodeCenter { get; set; }
    public string TelNumber { get; set; }
    public string Address { get; set; }
    public int BankId { get; set; }



}
