using MiniBlog.Core.Domain.People.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace MiniBlog.Core.Contracts.People.Commands;

public interface IPersonCommandRepository : ICommandRepository<Person>
{
}