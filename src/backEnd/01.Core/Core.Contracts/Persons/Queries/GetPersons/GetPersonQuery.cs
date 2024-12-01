using Core.Contracts.Persons.Queries.GetPersons;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace Core.Contracts.Persons.Queries.GetPersons;
public class GetPersonQuery : PageQuery<PagedData<PersonDto>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? Age { get; set; }


}
