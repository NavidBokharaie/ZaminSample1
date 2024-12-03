using Core.Contracts.Banks.Commands;
using Core.Domain.Banks.Entities;
using Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace Infra.Data.Sql.Commands.Banks;

public class BankCommandRepository :
        BaseCommandRepository<Bank, ZaminSample1CommandDbContext, int>,
        IBankCommandRepository
{
    public BankCommandRepository(ZaminSample1CommandDbContext dbContext) : base(dbContext)
    {
    }
}
