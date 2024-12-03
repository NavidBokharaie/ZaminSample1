using Core.Contracts.Banks.Queries.GetBanks;
using Core.Contracts.Banks.Queries.GetBankById;
using Zamin.Core.Contracts.Data.Queries;
//EntityIQueryRepositoryUsingReplacementText

namespace Core.Contracts.Banks.Queries;

public interface IBankQueryRepository : IQueryRepository
{
    Task<BankByIdDto> SelectAsync(GetBankByIdQuery request);
    Task<PagedData<BankDto>> SelectAsync(GetBankQuery request);

//EntityIQueryRepositoryReplacementText
}
