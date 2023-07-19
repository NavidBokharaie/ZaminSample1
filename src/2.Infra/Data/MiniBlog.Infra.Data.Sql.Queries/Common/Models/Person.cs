namespace MiniBlog.Infra.Data.Sql.Queries.Common.Models;

public partial class Person
{
	public long Id { get; set; }

	public string FirstName { get; set; } = null!;

	public string LastName { get; set; } = null!;

	public string? CreatedByUserId { get; set; }

	public DateTime? CreatedDateTime { get; set; }

	public string? ModifiedByUserId { get; set; }

	public DateTime? ModifiedDateTime { get; set; }

	public Guid BusinessId { get; set; }
}
