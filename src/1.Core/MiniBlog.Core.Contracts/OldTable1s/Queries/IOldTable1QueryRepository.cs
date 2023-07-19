using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniBlog.Core.Contracts.OldTable1s.Queries;

public interface IOldTable1QueryRepository : IQueryRepository
{
	Task<PagedData<OldTable1Dto>> Select(GetOldTable1Query dto);
	public Task<OldTable1ByIdDto> Select(GetOldTable1ByIdQuery query);
}