using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Contracts.OldTable1s.Queries;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;
using MiniBlog.Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;
using Zamin.Utilities.Extensions;

namespace MiniBlog.Infra.Data.Sql.Queries.OldTable1s;

public class OldTable1QueryRepository : BaseQueryRepository<MiniblogQueryDbContext>,
	IOldTable1QueryRepository
{
	public MiniblogQueryDbContext _dbContext { get; }

	public OldTable1QueryRepository(MiniblogQueryDbContext dbContext) : base(dbContext)
	{
		_dbContext = dbContext;
	}
	public async Task<OldTable1ByIdDto> Select(GetOldTable1ByIdQuery query)
	{
		return await _dbContext.OldTable1s.Select(c => new OldTable1ByIdDto()
		{
			Id = c.CcOldTable1,
			BusinessId = c.BusinessId,
			FirstName = c.FirstName,
			LastName = c.LastName
		}).FirstAsync(c => c.BusinessId.Equals(query.BusinessId));
	}

	public async Task<PagedData<OldTable1Dto>> Select(GetOldTable1Query dto)
	{
		#region Query
		var query = _dbContext.OldTable1s.AsQueryable();
		#endregion

		#region Filters

		query = query.WhereIf(dto.FirstName != null, p => p.FirstName.Contains(dto.FirstName));
		query = query.WhereIf(dto.LastName != null, p => p.LastName.Contains(dto.LastName));
		query = query.WhereIf(dto.BusinessId != Guid.Empty, m => m.BusinessId == dto.BusinessId);

		#endregion

		#region Result

		var select = query
			.Select(c => new OldTable1Dto
			{
				Id = c.CcOldTable1,
				BusinessId = c.BusinessId,
				FirstName = c.FirstName,
				LastName = c.LastName,
			});
		var result = await select.ToPagedData(dto, c => c);

		#endregion

		return result;
	}
}
