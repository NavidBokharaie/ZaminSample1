using Core.Contracts.Tests.Queries;
using Core.Contracts.Tests.Queries.GetTestById;

namespace Core.ApplicationServices.Tests.Queries.GetTestById;

public class GetTestByIdQueryHandler : QueryHandler<GetTestByIdQuery, IEnumerable<TestByIdDto>>
{
    private readonly ITestQueryRepository _testQueryRepository;

    public GetTestByIdQueryHandler(ZaminServices zaminServices, ITestQueryRepository testQueryRepository) : base(zaminServices)
    {
        _testQueryRepository = testQueryRepository;
    }

    public override async Task<QueryResult<IEnumerable<TestByIdDto>>> Handle(GetTestByIdQuery query)
    {
        var result = await _testQueryRepository.SelectTestByIdAsync(query);
        return await ResultAsync(result);
    }
}