namespace Core.Contracts.Banks.Commands.AddHesab;

public class AddHesabCommand : ICommand<int>
{
    public int HesabNumber { get; set; }
    public string CodeCenter { get; set; }
    public string TelNumber { get; set; }
    public string Address { get; set; }
    public int BankId { get; set; }

}
