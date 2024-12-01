using Microsoft.AspNetCore.Mvc;
using Core.Contracts.Persons.Commands.CreatePerson;
using Core.Contracts.Persons.Queries.GetPersons;
using Core.Contracts.Persons.Queries.GetPersonById;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;
//EntityControllerUsingReplacementText

namespace Endpoints.API.Persons;

[Route("api/[controller]")]
public class PersonController : BaseController
{
    [HttpPost("create")]
    public async Task<IActionResult> CreatePerson([FromBody] CreatePersonCommand createPerson)
    {
        return await Create<CreatePersonCommand, int>(createPerson);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetPerson([FromQuery] GetPersonQuery query)
    {
        return await Query<GetPersonQuery, PagedData<PersonDto>>(query);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetPersonById([FromQuery] GetPersonByIdQuery query)
    {
        return await Query<GetPersonByIdQuery, PersonByIdDto>(query);
    }


//EntityControllerMethodsReplacementText
}
