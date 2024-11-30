namespace Core.Domain.Tests.Events;
public class TestCreated : IDomainEvent
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int? DetailId { get; private set; }
    public byte StatusId { get; private set; }
    public int? PictureId { get; private set; }

    public TestCreated(
        int id,
        string firstName,
        string lastName,
        int? detailId,
        byte statusId,
        int? pictureId
        )
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        DetailId = detailId;
        StatusId = statusId;
        PictureId = pictureId;
    }
}