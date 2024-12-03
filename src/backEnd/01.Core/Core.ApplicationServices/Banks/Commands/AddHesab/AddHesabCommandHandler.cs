using Core.Contracts.Banks.Commands;
using Core.Contracts.Banks.Commands.AddHesab;

namespace Core.ApplicationServices.Banks.Commands.AddHesab;

public class AddHesabCommandHandler : CommandHandler<AddHesabCommand, int>
{
    private readonly IBankCommandRepository _bankCommandRepository;
    public AddHesabCommandHandler(ZaminServices zaminServices, IBankCommandRepository bankCommandRepository) : base(zaminServices)
    {
        _bankCommandRepository = bankCommandRepository;
    }

    public override async Task<CommandResult<int>> Handle(AddHesabCommand request)
    {
        var entity = await _bankCommandRepository.GetGraphAsync(request.BankId);
        //var userId = int.Parse(_zaminServices.UserInfoService.UserId());
        var hesab = entity.AddHesab(
            request.HesabNumber,
            request.CodeCenter,
            request.TelNumber,
            request.Address,
            request.BankId
        );
        await _bankCommandRepository.CommitAsync();

        return await OkAsync(hesab.Id);
    }
}
