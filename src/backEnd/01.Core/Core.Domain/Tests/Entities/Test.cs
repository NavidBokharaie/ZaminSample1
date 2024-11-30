using Core.Domain.Tests.Events;

namespace Core.Domain.Tests.Entities;
public class Test : AggregateRoot<int>
{
    #region Properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int? DetailId { get; private set; }
    public byte StatusId { get; private set; }
    public int? PictureId { get; private set; }
    #endregion

    #region Constructors

    private Test()
    {
    }

    private Test(
        string firstName,
        string lastName,
        int? detailId,
        byte statusId,
        int? pictureId
    )
    {
        FirstName = firstName;
        LastName = lastName;
        DetailId = detailId;
        StatusId = statusId;
        PictureId = pictureId;
        AddEvent(new TestCreated(Id,
            FirstName,
            LastName,
            DetailId,
            StatusId,
            PictureId));
    }
    #endregion

    #region Commands

    public static Test Create(
        string firstName,
        string lastName,
        int? detailId,
        byte statusId,
        int? pictureId
    ) => new(
            firstName,
            lastName,
            detailId,
            statusId,
            pictureId
        );
    #endregion
}
