using Microsoft.AspNetCore.Mvc;
using MiniBlog.Core.Contracts.OldTable1s.Commands.CreateOldTable1;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace MiniBlog.Endpoints.API.OldTable1s;

[Route("api/[controller]")]
public class OldTable1Controller : BaseController
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateOldTable1(CreateOldTable1Command createOldTable1)
    {
        return await Create<CreateOldTable1Command, Guid>(createOldTable1);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetOldTable1(GetOldTable1Query query)
    {
        return await Query<GetOldTable1Query, PagedData<OldTable1Dto>>(query);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetOldTable1ById(GetOldTable1ByIdQuery query)
    {
        return await Query<GetOldTable1ByIdQuery, OldTable1ByIdDto>(query);
    }
}
