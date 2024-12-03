using Core.Contracts.Banks.Queries.GetBanks;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace Core.Contracts.Banks.Queries.GetBanks;
public class GetBankQuery : PageQuery<PagedData<BankDto>>
{
    public string Name { get; set; }
    public int? Code { get; set; }
    public int? UserId { get; set; }
    public DateTime? CreatedDate { get; set; }


}
