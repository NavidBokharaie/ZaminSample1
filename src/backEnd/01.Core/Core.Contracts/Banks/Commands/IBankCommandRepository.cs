using Core.Domain.Banks.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace Core.Contracts.Banks.Commands;

public interface IBankCommandRepository : ICommandRepository<Bank, int>
{
}
