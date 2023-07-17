using MiniBlog.Core.Contracts.People.Queries;
using MiniBlog.Core.Contracts.People.Queries.GetPeople;
using MiniBlog.Core.Contracts.People.Queries.GetPerson;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.People.Queries.GetPeople;

public class GetPersonQueryHandler : QueryHandler<GetPersonQuery, PagedData<PersonDto>>
{
    public IPersonQueryRepository _personQueryRepository { get; }
    public GetPersonQueryHandler(ZaminServices zaminServices, IPersonQueryRepository personQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
    }

    public override async Task<QueryResult<PagedData<PersonDto>>> Handle(GetPersonQuery query)
    {
        var people = await _personQueryRepository.Select(query);
        return await ResultAsync(people);
    }
}