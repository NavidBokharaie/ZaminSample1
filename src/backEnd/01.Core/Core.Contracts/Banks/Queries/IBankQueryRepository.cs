using Core.Contracts.Banks.Queries.GetBanks;
using Core.Contracts.Banks.Queries.GetBankById;
using Zamin.Core.Contracts.Data.Queries;

using Core.Contracts.Banks.Queries.GetHesabById;
using Core.Contracts.Banks.Queries.GetHesabs;
//EntityIQueryRepositoryUsingReplacementText

namespace Core.Contracts.Banks.Queries;

public interface IBankQueryRepository : IQueryRepository
{
    Task<BankByIdDto> SelectAsync(GetBankByIdQuery request);
    Task<PagedData<BankDto>> SelectAsync(GetBankQuery request);


Task<HesabByIdDto> SelectAsync(GetHesabByIdQuery request);
Task<PagedData<HesabDto>> SelectAsync(GetHesabQuery request);
//EntityIQueryRepositoryReplacementText
}
