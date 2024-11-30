using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Zamin.Core.Domain.Entities;
using Zamin.Extensions.UsersManagement.Abstractions;
using Zamin.Infra.Data.Sql.Commands.Extensions;

namespace Infra.Data.Sql.Commands.Common.AuditableShadowProperty;

public class AddSaappAuditDataInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        AddShadowProperties(eventData);
        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        AddShadowProperties(eventData);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private void AddShadowProperties(DbContextEventData eventData)
    {
        if (eventData.Context is null)
            throw new ArgumentNullException(nameof(eventData.Context), "DbContext cannot be null");

        var changeTracker = eventData.Context.ChangeTracker;
        var userInfoService = eventData.Context.GetService<IUserInfoService>();

        var entries = changeTracker.Entries()
            .Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified) &&
                        !ExcludedAggregateShadowProperty.ExcludedEntities.Contains(e.Metadata.ClrType) &&
                        typeof(Entity).IsAssignableFrom(e.Metadata.ClrType))
            .ToList();

        foreach (var entry in entries)
        {
            AddShadowProperties(entry, userInfoService);
        }
    }

    private void AddShadowProperties(EntityEntry entityEntry, IUserInfoService userInfoService)
    {
        userInfoService.GetUserAgent();
        userInfoService.GetUserIp();
        DateTime utcNow = DateTime.UtcNow;
        string str = userInfoService.UserIdOrDefault();

        if (entityEntry.State == EntityState.Modified)
        {
            entityEntry.Property(AuditableShadowProperties.ModifiedDateTime).CurrentValue = utcNow;
            entityEntry.Property(AuditableShadowProperties.ModifiedByUserId).CurrentValue = str;
        }

        if (entityEntry.State == EntityState.Added)
        {
            entityEntry.Property(AuditableShadowProperties.CreatedDateTime).CurrentValue = utcNow;
            entityEntry.Property(AuditableShadowProperties.CreatedByUserId).CurrentValue = str;
        }
    }
}