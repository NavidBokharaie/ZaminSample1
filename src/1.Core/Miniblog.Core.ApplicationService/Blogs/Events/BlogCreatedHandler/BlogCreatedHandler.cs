using Microsoft.Extensions.Logging;
using MiniBlog.Core.Contracts.People.Commands;
using MiniBlog.Core.Domain.Blogs.Events;
using MiniBlog.Core.Domain.People.Entities;
using Zamin.Core.Contracts.ApplicationServices.Events;

namespace MiniBlog.Core.ApplicationService.Blogs.Events.BlogCreatedHandler;
public class BlogCreatedHandler : IDomainEventHandler<BlogCreated>
{
    private readonly ILogger<BlogCreatedHandler> _logger;
    private readonly IPersonCommandRepository _personCommandRepository;

    public BlogCreatedHandler(ILogger<BlogCreatedHandler> logger,
                                IPersonCommandRepository personCommandRepository)
    {
        _logger = logger;
        _personCommandRepository = personCommandRepository;
    }
    public async Task Handle(BlogCreated Event)
    {
        try
        {
            var businessId = Guid.NewGuid();
            Person person = Person.Create(
                businessId,
                "Test Event First Name 1 - " + DateTime.Now.ToString(),
                "Test Event Last Name 1 - " + DateTime.Now.ToLongTimeString()
            );
            await _personCommandRepository.InsertAsync(person);
            await _personCommandRepository.CommitAsync();

            _logger.LogInformation("Handeled {Event} in BlogCreatedHandler", Event.GetType().Name);
            await Task.CompletedTask;
        }
        catch (Exception ex)
        {
            throw;
        }

    }
}
