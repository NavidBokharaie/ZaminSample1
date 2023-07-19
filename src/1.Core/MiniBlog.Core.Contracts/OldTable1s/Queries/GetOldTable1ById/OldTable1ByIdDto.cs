namespace MiniBlog.Core.Contracts.OldTable1s.Queries.GetOldTable1ById;
public class OldTable1ByIdDto
{
	public long Id { get; set; }
	public Guid BusinessId { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
}