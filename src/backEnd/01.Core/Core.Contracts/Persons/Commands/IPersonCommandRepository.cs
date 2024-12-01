using Core.Domain.Persons.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace Core.Contracts.Persons.Commands;

public interface IPersonCommandRepository : ICommandRepository<Person, int>
{
}
