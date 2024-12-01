using Core.Contracts.Persons.Queries;
using Core.Contracts.Persons.Queries.GetPersons;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace Core.ApplicationServices.Persons.Queries.GetPersons;

public class GetPersonQueryHandler : QueryHandler<GetPersonQuery, PagedData<PersonDto>>
{
    public IPersonQueryRepository _personQueryRepository;
    public GetPersonQueryHandler(ZaminServices zaminServices, IPersonQueryRepository personQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
    }

    public override async Task<QueryResult<PagedData<PersonDto>>> Handle(GetPersonQuery query)
    {
        var persons = await _personQueryRepository.SelectAsync(query);
        return await ResultAsync(persons);
    }
}
