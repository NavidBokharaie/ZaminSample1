using Core.Contracts.Persons.Queries;
using Core.Contracts.Persons.Queries.GetPersonById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace Core.ApplicationServices.Persons.Queries.GetPersonById;

public class GetPersonByIdQueryHandler : QueryHandler<GetPersonByIdQuery, PersonByIdDto>
{
    private readonly IPersonQueryRepository _personQueryRepository;

    public GetPersonByIdQueryHandler(ZaminServices zaminServices,
                                      IPersonQueryRepository personQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
    }

    public override async Task<QueryResult<PersonByIdDto>> Handle(GetPersonByIdQuery query)
    {
        var person = await _personQueryRepository.SelectAsync(query);
        return await ResultAsync(person);
    }
}
