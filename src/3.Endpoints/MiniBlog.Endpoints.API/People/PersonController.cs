using Microsoft.AspNetCore.Mvc;
using MiniBlog.Core.Contracts.People.Commands.CreatePerson;
using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Contracts.People.Queries.GetPerson;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace MiniBlog.Endpoints.API.People;

[Route("api/[controller]")]
public class PersonController : BaseController
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreatePerson(CreatePersonCommand createPerson)
    {
        return await Create<CreatePersonCommand, Guid>(createPerson);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetPerson(GetPersonQuery query)
    {
        return await Query<GetPersonQuery, PagedData<PersonDto>>(query);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetPersonByBusinessId(GetPersonByIdQuery query)
    {
        return await Query<GetPersonByIdQuery, PersonByIdDto>(query);
    }
}
