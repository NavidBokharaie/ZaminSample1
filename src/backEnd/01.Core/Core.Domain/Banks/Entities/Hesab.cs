namespace Core.Domain.Banks.Entities;
public class Hesab : Entity<int>
{
    #region Properties

    public int HesabNumber { get; private set; }
    public string CodeCenter { get; private set; }
    public string TelNumber { get; private set; }
    public string Address { get; private set; }
    public int BankId { get; private set; }


    #endregion

    #region Constructors

    private Hesab()
    {
    }

    private Hesab(
        int hesabNumber,
        string codeCenter,
        string telNumber,
        string address,
        int bankId
    )
    {
        HesabNumber = hesabNumber;
        CodeCenter = codeCenter;
        TelNumber = telNumber;
        Address = address;
        BankId = bankId;

    }

    internal static Hesab Create(
        int hesabNumber,
        string codeCenter,
        string telNumber,
        string address,
        int bankId
    )
    {
        return new(
            hesabNumber,
            codeCenter,
            telNumber,
            address,
            bankId
        );
    }

    #endregion
}
