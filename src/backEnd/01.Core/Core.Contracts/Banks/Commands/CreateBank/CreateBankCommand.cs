using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace Core.Contracts.Banks.Commands.CreateBank;

public class CreateBankCommand : ICommand<int>
{
    public string Name { get; set; }
    public int Code { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }

}
