namespace MiniBlog.Infra.Data.Sql.Queries.Common;

public partial class Person
{
    public long Id { get; set; }
    public Guid BusinessId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CreatedByUserId { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string? ModifiedByUserId { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
}
