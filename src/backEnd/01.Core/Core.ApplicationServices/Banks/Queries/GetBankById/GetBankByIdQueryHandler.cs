using Core.Contracts.Banks.Queries;
using Core.Contracts.Banks.Queries.GetBankById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace Core.ApplicationServices.Banks.Queries.GetBankById;

public class GetBankByIdQueryHandler : QueryHandler<GetBankByIdQuery, BankByIdDto>
{
    private readonly IBankQueryRepository _bankQueryRepository;

    public GetBankByIdQueryHandler(ZaminServices zaminServices,
                                      IBankQueryRepository bankQueryRepository) : base(zaminServices)
    {
        _bankQueryRepository = bankQueryRepository;
    }

    public override async Task<QueryResult<BankByIdDto>> Handle(GetBankByIdQuery query)
    {
        var bank = await _bankQueryRepository.SelectAsync(query);
        return await ResultAsync(bank);
    }
}
