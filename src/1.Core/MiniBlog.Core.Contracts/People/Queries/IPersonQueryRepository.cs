using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniBlog.Core.Contracts.People.Queries;

public interface IPersonQueryRepository : IQueryRepository
{
    Task<PersonByIdDto?> SelectAsync(GetPersonByIdQuery dto);
    Task<PagedData<PersonDto>> SelectAsync(GetPersonQuery dto);
}