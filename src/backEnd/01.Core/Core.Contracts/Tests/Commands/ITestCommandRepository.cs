using Core.Domain.Tests.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace Core.Contracts.Tests.Commands;

public interface ITestCommandRepository : ICommandRepository<Test, int>
{
}
