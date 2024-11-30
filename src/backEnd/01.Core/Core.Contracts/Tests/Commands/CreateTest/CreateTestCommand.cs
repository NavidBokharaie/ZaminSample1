namespace Core.Contracts.Tests.Commands.CreateTest;

public class CreateTestCommand : ICommand<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? DetailId { get; set; }
    public byte StatusId { get; set; }
    public int? PictureId { get; set; }
}