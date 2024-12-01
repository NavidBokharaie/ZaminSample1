using Microsoft.EntityFrameworkCore;
using Core.Contracts.Persons.Queries;
using Core.Contracts.Persons.Queries.GetPersons;
using Core.Contracts.Persons.Queries.GetPersonById;
using Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;
using Zamin.Utilities.Extensions;
//EntityQueryRepositoryUsingReplacementText

namespace Infra.Data.Sql.Queries.Persons;

public class PersonQueryRepository : BaseQueryRepository<ZaminSample1QueryDbContext>,
    IPersonQueryRepository
{
    public PersonQueryRepository(ZaminSample1QueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<PersonByIdDto> SelectAsync(GetPersonByIdQuery request)
    {
        return await _dbContext.Persons.Select(c => new PersonByIdDto()
        {
            Id = c.Id,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Age = c.Age
        }).SingleOrDefaultAsync(c => c.Id.Equals(request.Id));
    }
    public async Task<PagedData<PersonDto>> SelectAsync(GetPersonQuery request)
    {
        #region Query
        var query = _dbContext.Persons.AsQueryable();
        #endregion

        #region Filters
        query = query.WhereIf(request.FirstName != null, p => p.FirstName.Contains(request.FirstName));
        query = query.WhereIf(request.LastName != null, p => p.LastName.Contains(request.LastName));
        query = query.WhereIf(request.Age != null, m => m.Age == request.Age);




        #endregion

        #region Result
        PagedData<PersonDto> result = await query.ToPagedData(request, c => new PersonDto
        {
            Id = c.Id,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Age = c.Age ,


        });

        return result;
        #endregion
    }

//EntityQueryRepositoryReplacementText
}
