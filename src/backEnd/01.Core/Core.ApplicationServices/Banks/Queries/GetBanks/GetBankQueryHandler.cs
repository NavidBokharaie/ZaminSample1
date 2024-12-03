using Core.Contracts.Banks.Queries;
using Core.Contracts.Banks.Queries.GetBanks;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace Core.ApplicationServices.Banks.Queries.GetBanks;

public class GetBankQueryHandler : QueryHandler<GetBankQuery, PagedData<BankDto>>
{
    public IBankQueryRepository _bankQueryRepository;
    public GetBankQueryHandler(ZaminServices zaminServices, IBankQueryRepository bankQueryRepository) : base(zaminServices)
    {
        _bankQueryRepository = bankQueryRepository;
    }

    public override async Task<QueryResult<PagedData<BankDto>>> Handle(GetBankQuery query)
    {
        var banks = await _bankQueryRepository.SelectAsync(query);
        return await ResultAsync(banks);
    }
}
