using Core.Contracts.Persons.Queries.GetPersons;
using Core.Contracts.Persons.Queries.GetPersonById;
using Zamin.Core.Contracts.Data.Queries;
//EntityIQueryRepositoryUsingReplacementText

namespace Core.Contracts.Persons.Queries;

public interface IPersonQueryRepository : IQueryRepository
{
    Task<PersonByIdDto> SelectAsync(GetPersonByIdQuery request);
    Task<PagedData<PersonDto>> SelectAsync(GetPersonQuery request);

//EntityIQueryRepositoryReplacementText
}
