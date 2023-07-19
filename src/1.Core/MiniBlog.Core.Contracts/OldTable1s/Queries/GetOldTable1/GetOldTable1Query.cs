using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1;
public class GetOldTable1Query : PageQuery<PagedData<OldTable1Dto>>
{
	public long Id { get; set; }
	public Guid BusinessId { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
}
