using Core.Contracts.Tests.Queries;
using Core.Contracts.Tests.Queries.GetTests;

namespace Infra.Data.Sql.Queries.Tests;

public class TestQueryRepository : BaseQueryRepository<ZaminSample1QueryDbContext>,
    ITestQueryRepository
{
    public TestQueryRepository(ZaminSample1QueryDbContext dbContext) : base(dbContext)
    {
    }
    public async Task<IEnumerable<TestDto>> SelectAsync(GetTestQuery dto)
    {
        #region 
        var q = (from test in _dbContext.Tests
                 select new TestDto()
                 {
                     Id = test.Id,
                     FirstName = test.FirstName,
                     LastName = test.LastName
                 });
        #endregion

        #region Result
        //var result = await q.DefaultIfEmpty();
        return await q.ToListAsync();
        #endregion
    }
}