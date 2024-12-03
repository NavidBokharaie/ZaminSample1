using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace Core.Contracts.Banks.Queries.GetBankById;

public class GetBankByIdQuery : IQuery<BankByIdDto>
{
    public int Id { get; set; }
}
