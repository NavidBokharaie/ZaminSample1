using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Contracts.People.Queries.GetPerson;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniBlog.Core.Contracts.People.Queries;

public interface IPersonQueryRepository : IQueryRepository
{
    Task<PagedData<PersonDto>> Select(GetPersonQuery dto);
    public Task<PersonByIdDto> Select(GetPersonByIdQuery query);
}