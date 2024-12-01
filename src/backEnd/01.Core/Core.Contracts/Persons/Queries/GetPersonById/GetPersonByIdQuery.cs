using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace Core.Contracts.Persons.Queries.GetPersonById;

public class GetPersonByIdQuery : IQuery<PersonByIdDto>
{
    public int Id { get; set; }
}
