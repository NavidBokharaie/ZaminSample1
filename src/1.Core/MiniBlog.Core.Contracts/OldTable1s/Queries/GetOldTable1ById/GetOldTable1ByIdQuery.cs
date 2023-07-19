using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;

public class GetOldTable1ByIdQuery : IQuery<OldTable1ByIdDto>
{
    public Guid BusinessId { get; set; }
}