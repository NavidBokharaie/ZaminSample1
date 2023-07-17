using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Contracts.People.Queries;
using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Contracts.People.Queries.GetPerson;
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
    public async Task<PersonByIdDto> Select(GetPersonByIdQuery query)
    {
        return await _dbContext.People.Select(c => new PersonByIdDto()
        {
            Id = c.Id,
            BusinessId = c.BusinessId,
            FirstName = c.FirstName,
            LastName = c.LastName
        }).FirstOrDefaultAsync(c => c.BusinessId.Equals(query.BusinessId));
    }
    public async Task<PagedData<PersonDto>> Select(GetPersonQuery dto)
    {
        #region Query
        var query = _dbContext.People.AsQueryable();
        #endregion

        #region Filters
        query = query.WhereIf(dto.FirstName != null, p => p.FirstName.Contains(dto.FirstName));
        query = query.WhereIf(dto.LastName != null, p => p.LastName.Contains(dto.LastName));
        query = query.WhereIf(dto.BusinessId != Guid.Empty, m => m.BusinessId == dto.BusinessId);

        query = query.WhereIf(dto.CreatedDateTime != null, m => m.CreatedDateTime == dto.CreatedDateTime);
        query = query.WhereIf(dto.ModifiedDateTime != null, m => m.ModifiedDateTime == dto.ModifiedDateTime);
        query = query.WhereIf(dto.CreatedByUserId != null, m => m.CreatedByUserId == dto.CreatedByUserId);
        query = query.WhereIf(dto.ModifiedByUserId != null, m => m.ModifiedByUserId == dto.ModifiedByUserId);

        query = dto.SortBy != null ? query.OrderByField(dto.SortBy, dto.SortAscending) : query;
        query = dto.PageNumber >= 0 ? query.Skip((dto.PageNumber - 1) * dto.PageSize) : query;
        query = dto.PageSize >= 0 ? query.Take(dto.PageSize) : query;
        #endregion

        #region Result
        var select = query
            .Select(c => new PersonDto
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
        var result = new PagedData<PersonDto>
        {
            TotalCount = dto.NeedTotalCount ? query.Count() : -1,
            PageNumber = dto.PageNumber,
            PageSize = dto.PageSize,
            QueryResult = select.ToList()
        };
        return result;
        #endregion
    }
}
