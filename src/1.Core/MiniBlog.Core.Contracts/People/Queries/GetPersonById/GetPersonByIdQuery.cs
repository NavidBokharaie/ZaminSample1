using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniBlog.Core.Contracts.People.Queries.GetPersonById;

public class GetPersonByIdQuery : IQuery<PersonByIdDto>
{
    public Guid BusinessId { get; set; }
}