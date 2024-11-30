using Core.Contracts.Tests.Queries.GetTestById;

namespace Core.Contracts.Tests.Queries;

public interface ITestQueryRepository : IQueryRepository
{
    Task<IEnumerable<TestByIdDto>> SelectTestByIdAsync(GetTestByIdQuery dto);
}
