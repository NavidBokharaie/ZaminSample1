using Core.Contracts.Persons.Commands;
using Core.Domain.Persons.Entities;
using Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace Infra.Data.Sql.Commands.Persons;

public class PersonCommandRepository :
        BaseCommandRepository<Person, ZaminSample1CommandDbContext, int>,
        IPersonCommandRepository
{
    public PersonCommandRepository(ZaminSample1CommandDbContext dbContext) : base(dbContext)
    {
    }
}
