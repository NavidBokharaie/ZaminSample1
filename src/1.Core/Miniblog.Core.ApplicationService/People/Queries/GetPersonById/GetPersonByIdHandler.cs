using MiniBlog.Core.Contracts.People.Queries;
using MiniBlog.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.People.Queries.GetPersonById;

public class GetPersonByIdHandler : QueryHandler<GetPersonByIdQuery, PersonByIdDto>
{
    private readonly IPersonQueryRepository _personQueryRepository;

    public GetPersonByIdHandler(ZaminServices zaminServices,
                                      IPersonQueryRepository personQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
    }

    public override async Task<QueryResult<PersonByIdDto>> Handle(GetPersonByIdQuery query)
    {
        var person = await _personQueryRepository.Select(query);
        return Result(person);
    }
}