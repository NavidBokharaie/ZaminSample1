using Core.Contracts.Tests.Queries.GetTests;

namespace Core.Contracts.Tests.Queries;

public interface ITestQueryRepository : IQueryRepository
{
    Task<IEnumerable<TestDto>> SelectAsync(GetTestQuery dto);
}
