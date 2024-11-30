using Core.Contracts.Tests.Queries;
using Core.Contracts.Tests.Queries.GetTests;

namespace Core.ApplicationServices.Tests.Queries.GetTests;

public class GetTestQueryHandler : QueryHandler<GetTestQuery, IEnumerable<TestDto>>
{
    private readonly ITestQueryRepository _testQueryRepository;

    public GetTestQueryHandler(ZaminServices zaminServices, ITestQueryRepository testQueryRepository) : base(zaminServices)
    {
        _testQueryRepository = testQueryRepository;
    }

    public override async Task<QueryResult<IEnumerable<TestDto>>> Handle(GetTestQuery query)
    {
        var result = await _testQueryRepository.SelectAsync(query);
        return await ResultAsync(result);
    }
}