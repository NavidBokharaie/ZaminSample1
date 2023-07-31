using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Contracts.People.Queries;
using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using MiniBlog.Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;
using Zamin.Utilities.Extensions;

namespace MiniBlog.Infra.Data.Sql.Queries.People;

public class PersonQueryRepository : BaseQueryRepository<MiniblogQueryDbContext>,
    IPersonQueryRepository
{
    public MiniblogQueryDbContext _dbContext { get; }

    public PersonQueryRepository(MiniblogQueryDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<PersonByIdDto?> SelectAsync(GetPersonByIdQuery query)
    {
        return await _dbContext.People.Select(c => new PersonByIdDto()
        {
            Id = c.Id,
            BusinessId = c.BusinessId,
            FirstName = c.FirstName,
            LastName = c.LastName
        }).FirstOrDefaultAsync(c => c.BusinessId.Equals(query.BusinessId));
    }
    public async Task<PagedData<PersonDto>> SelectAsync(GetPersonQuery dto)
    {
        #region Query
        var entities = _dbContext.People.AsQueryable();
        #endregion

        #region Filters
        entities = entities.WhereIf(dto.FirstName != null, p => p.FirstName.Contains(dto.FirstName));
        entities = entities.WhereIf(dto.LastName != null, p => p.LastName.Contains(dto.LastName));
        entities = entities.WhereIf(dto.BusinessId != Guid.Empty, m => m.BusinessId == dto.BusinessId);

        entities = entities.WhereIf(dto.CreatedDateTime != null, m => m.CreatedDateTime == dto.CreatedDateTime);
        entities = entities.WhereIf(dto.ModifiedDateTime != null, m => m.ModifiedDateTime == dto.ModifiedDateTime);
        entities = entities.WhereIf(dto.CreatedByUserId != null, m => m.CreatedByUserId == dto.CreatedByUserId);
        entities = entities.WhereIf(dto.ModifiedByUserId != null, m => m.ModifiedByUserId == dto.ModifiedByUserId);

        #endregion

        #region Result
        PagedData<PersonDto> result = await entities.ToPagedData(dto, c => new PersonDto
        {
            Id = c.Id,
            BusinessId = c.BusinessId,
            FirstName = c.FirstName,
            LastName = c.LastName,

            CreatedByUserId = c.CreatedByUserId,
            CreatedByUserName = null,
            ModifiedByUserId = c.ModifiedByUserId,
            ModifiedByUserName = null,
            CreatedDateTime = c.CreatedDateTime,
            ModifiedDateTime = c.ModifiedDateTime
        });

        return result;
        #endregion
    }
}
