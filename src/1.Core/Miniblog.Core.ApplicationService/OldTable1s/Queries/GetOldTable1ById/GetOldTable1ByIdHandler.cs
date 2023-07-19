using MiniBlog.Core.Contracts.OldTable1s.Queries;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.OldTable1s.Queries.GetOldTable1ById;

public class GetOldTable1ByIdHandler : QueryHandler<GetOldTable1ByIdQuery, OldTable1ByIdDto>
{
    private readonly IOldTable1QueryRepository _OldTable1QueryRepository;

    public GetOldTable1ByIdHandler(ZaminServices zaminServices,
                                      IOldTable1QueryRepository OldTable1QueryRepository) : base(zaminServices)
    {
        _OldTable1QueryRepository = OldTable1QueryRepository;
    }

    public override async Task<QueryResult<OldTable1ByIdDto>> Handle(GetOldTable1ByIdQuery query)
    {
        var OldTable1 = await _OldTable1QueryRepository.Select(query);
        return Result(OldTable1);
    }
}