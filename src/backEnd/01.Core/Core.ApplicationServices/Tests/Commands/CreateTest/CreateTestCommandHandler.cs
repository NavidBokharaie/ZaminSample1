using Core.Contracts.Tests.Commands;
using Core.Contracts.Tests.Commands.CreateTest;
using Core.Domain.Tests.Entities;

namespace Core.ApplicationServices.Tests.Commands.CreateTest;

public class CreateTestCommandHandler : CommandHandler<CreateTestCommand, int>
{
    private readonly ITestCommandRepository _testCommandRepository;
    public CreateTestCommandHandler(ZaminServices zaminServices, ITestCommandRepository testCommandRepository) : base(zaminServices)
    {
        _testCommandRepository = testCommandRepository;
    }

    public override async Task<CommandResult<int>> Handle(CreateTestCommand createTestCommand)
    {
        Test test = Test.Create(
            createTestCommand.FirstName,
            createTestCommand.LastName,
            createTestCommand.DetailId,
            createTestCommand.StatusId,
            createTestCommand.PictureId
        );
        await _testCommandRepository.InsertAsync(test);
        await _testCommandRepository.CommitAsync();
        return await OkAsync(test.Id);
    }
}