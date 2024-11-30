using Zamin.Core.Domain.Entities;
using Zamin.Infra.Data.Sql.Commands;

namespace Infra.Data.Sql.Commands.Common.Extensions;

public class BaseCommandRepository<TEntity, TDbContext> : BaseCommandRepository<TEntity, TDbContext, int> where TEntity : AggregateRoot<int>
    where TDbContext : BaseCommandDbContext
{
    public BaseCommandRepository(TDbContext dbContext) : base(dbContext)
    {
    }
}