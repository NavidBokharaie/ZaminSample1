namespace MiniBlog.Infra.Data.Sql.Queries.Common.Models;

public partial class OldTable1
{
	public long CcOldTable1 { get; set; }

	public string FirstName { get; set; } = null!;

	public string LastName { get; set; } = null!;

	public Guid BusinessId { get; set; }
}
