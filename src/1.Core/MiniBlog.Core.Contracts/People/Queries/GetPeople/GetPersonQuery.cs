using MiniBlog.Core.Contracts.People.Queries.GetPerson;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniBlog.Core.Contracts.People.Queries.GetPeople;
public class GetPersonQuery : PageQuery<PagedData<PersonDto>>
{
    public long Id { get; set; }
    public Guid BusinessId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? CreatedByUserId { get; set; }
    public string? CreatedByUserName { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string? ModifiedByUserId { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
}
