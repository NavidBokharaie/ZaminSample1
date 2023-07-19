using MiniBlog.Core.Contracts.OldTable1s.Queries;
using MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.OldTable1s.Queries.GetOldTable1;

public class GetOldTable1QueryHandler : QueryHandler<GetOldTable1Query, PagedData<OldTable1Dto>>
{
    public IOldTable1QueryRepository _OldTable1QueryRepository { get; }
    public GetOldTable1QueryHandler(ZaminServices zaminServices, IOldTable1QueryRepository OldTable1QueryRepository) : base(zaminServices)
    {
        _OldTable1QueryRepository = OldTable1QueryRepository;
    }

    public override async Task<QueryResult<PagedData<OldTable1Dto>>> Handle(GetOldTable1Query query)
    {
        var people = await _OldTable1QueryRepository.Select(query);
        return await ResultAsync(people);
    }
}