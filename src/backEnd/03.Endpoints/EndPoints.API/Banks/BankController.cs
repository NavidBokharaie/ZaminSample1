using Microsoft.AspNetCore.Mvc;
using Core.Contracts.Banks.Commands.CreateBank;
using Core.Contracts.Banks.Queries.GetBanks;
using Core.Contracts.Banks.Queries.GetBankById;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;
//EntityControllerUsingReplacementText

namespace Endpoints.API.Banks;

[Route("api/[controller]")]
public class BankController : BaseController
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateBank([FromBody] CreateBankCommand createBank)
    {
        return await Create<CreateBankCommand, int>(createBank);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetBank([FromQuery] GetBankQuery query)
    {
        return await Query<GetBankQuery, PagedData<BankDto>>(query);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetBankById([FromQuery] GetBankByIdQuery query)
    {
        return await Query<GetBankByIdQuery, BankByIdDto>(query);
    }


//EntityControllerMethodsReplacementText
}
