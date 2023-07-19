using MiniBlog.Core.Contracts.OldTable1s.Commands;
using MiniBlog.Core.Domain.OldTable1s.Entities;
using MiniBlog.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace MiniBlog.Infra.Data.Sql.Commands.OldTable1s;

public class OldTable1CommandRepository :
        BaseCommandRepository<OldTable1, MiniblogCommandDbContext>,
        IOldTable1CommandRepository
{
    public OldTable1CommandRepository(MiniblogCommandDbContext dbContext) : base(dbContext)
    {
    }
}
