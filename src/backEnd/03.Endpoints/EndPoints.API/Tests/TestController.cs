using Core.Contracts.Tests.Commands.CreateTest;
using Core.Contracts.Tests.Queries.GetTests;

namespace EndPoints.API.Tests;

[Route("api/[controller]")]
public class TestController : BaseController
{
    [HttpGet("getTests")]
    public async Task<IActionResult> GetTest([FromQuery] GetTestQuery query)
    {
        return await Query<GetTestQuery, IEnumerable<TestDto>>(query);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateTest([FromBody] CreateTestCommand createTest)
    {
        return await Create<CreateTestCommand, int>(createTest);
    }
}
