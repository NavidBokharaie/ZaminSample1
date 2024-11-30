using Core.Contracts.Tests.Commands.CreateTest;
using Core.Contracts.Tests.Queries.GetTestById;

namespace EndPoints.API.Tests;

[Route("api/[controller]")]
public class TestController : BaseController
{
    [HttpGet("getTestById")]
    public async Task<IActionResult> GetTest([FromQuery] GetTestByIdQuery query)
    {
        return await Query<GetTestByIdQuery, IEnumerable<TestByIdDto>>(query);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateTest([FromBody] CreateTestCommand createTest)
    {
        return await Create<CreateTestCommand, int>(createTest);
    }
}
