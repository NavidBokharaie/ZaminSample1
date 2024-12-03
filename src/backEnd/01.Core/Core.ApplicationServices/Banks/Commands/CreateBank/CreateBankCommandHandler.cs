using Core.Contracts.Banks.Commands;
using Core.Contracts.Banks.Commands.CreateBank;
using Core.Domain.Banks.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace Core.ApplicationServices.Banks.Commands.CreateBank;
public class CreateBankCommandHandler : CommandHandler<CreateBankCommand, int>
{
    private readonly IBankCommandRepository _bankCommandRepository;
    public CreateBankCommandHandler(ZaminServices zaminServices, IBankCommandRepository bankCommandRepository) : base(zaminServices)
    {
        _bankCommandRepository = bankCommandRepository;
    }

    public override async Task<CommandResult<int>> Handle(CreateBankCommand createBankCommand)
    {
        Bank bank = Bank.Create(
            createBankCommand.Name,
            createBankCommand.Code,
            createBankCommand.UserId,
            createBankCommand.CreatedDate
        );
        await _bankCommandRepository.InsertAsync(bank);
        await _bankCommandRepository.CommitAsync();
        return await OkAsync(bank.Id);
    }
}
