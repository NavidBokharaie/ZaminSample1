using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniBlog.Core.Contracts.OldTable1s.Commands.CreateOldTable1;

public class CreateOldTable1Command : ICommand<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}