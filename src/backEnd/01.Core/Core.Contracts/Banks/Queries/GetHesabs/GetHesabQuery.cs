namespace Core.Contracts.Banks.Queries.GetHesabs;
public class GetHesabQuery : PageQuery<PagedData<HesabDto>>
{
    public int? HesabNumber { get; set; }
    public string CodeCenter { get; set; }
    public string TelNumber { get; set; }
    public string Address { get; set; }
    public int? BankId { get; set; }


}
