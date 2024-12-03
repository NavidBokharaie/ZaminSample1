using Core.Contracts.Banks.Queries;
using Core.Contracts.Banks.Queries.GetHesabs;

namespace Core.ApplicationServices.Banks.Queries.GetHesabs;

public class GetHesabQueryHandler : QueryHandler<GetHesabQuery, PagedData<HesabDto>>
{
    public IBankQueryRepository _bankQueryRepository;
    public GetHesabQueryHandler(ZaminServices zaminServices, IBankQueryRepository bankQueryRepository) : base(zaminServices)
    {
        _bankQueryRepository = bankQueryRepository;
    }

    public override async Task<QueryResult<PagedData<HesabDto>>> Handle(GetHesabQuery query)
    {
        var banks = await _bankQueryRepository.SelectAsync(query);
        return await ResultAsync(banks);
    }
}
