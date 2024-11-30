namespace Core.Contracts.Tests.Queries.GetTests;

public class GetTestQuery : IQuery<IEnumerable<TestDto>>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? DetailId { get; set; }
    public byte StatusId { get; set; }
    public int? PictureId { get; set; }
}