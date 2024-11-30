using Core.Contracts.Tests.Commands;
using Core.Domain.Tests.Entities;
using Zamin.Infra.Data.Sql.Commands;

namespace Infra.Data.Sql.Commands.Tests;

public class TestCommandRepository :
    BaseCommandRepository<Test, ZaminSample1CommandDbContext, int>,
        ITestCommandRepository
{
    public TestCommandRepository(ZaminSample1CommandDbContext dbContext) : base(dbContext)
    {
    }
}
