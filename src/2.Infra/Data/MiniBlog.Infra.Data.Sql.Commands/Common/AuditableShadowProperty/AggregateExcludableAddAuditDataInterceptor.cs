using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Zamin.Extensions.UsersManagement.Abstractions;
using Zamin.Infra.Data.Sql.Commands.Extensions;

namespace MiniBlog.Infra.Data.Sql.Commands.Common.AuditableShadowProperty
{
	public class AggregateExcludableAddAuditDataInterceptor : SaveChangesInterceptor
	{
		public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
		{
			AddShadowProperties(eventData.Context.ChangeTracker, eventData.Context.GetService<IUserInfoService>(), eventData.Context.ChangeTracker.Entries());
			return base.SavingChanges(eventData, result);
		}

		public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
		{
			AddShadowProperties(eventData.Context.ChangeTracker, eventData.Context.GetService<IUserInfoService>(), eventData.Context.ChangeTracker.Entries());
			return base.SavingChangesAsync(eventData, result, cancellationToken);
		}

		private static void AddShadowProperties(ChangeTracker changeTracker, IUserInfoService userInfoService, IEnumerable<EntityEntry> entries)
		{
			foreach (var entry in entries)
			{
				var entityType = entry.Metadata.ClrType;

				// Check if the entity being saved is in the excludedEntities list
				if (ExcludedAggregateShadowProperty.ExcludedEntities.Contains(entityType))
				{
					continue;
				}

				SetAuditableEntityPropertyValues(entry, userInfoService);
			}
		}

		private static void SetAuditableEntityPropertyValues(EntityEntry entry, IUserInfoService userInfoService)
		{
			var userAgent = userInfoService.GetUserAgent();
			var userIp = userInfoService.GetUserIp();
			var now = DateTime.UtcNow;
			var userId = userInfoService.UserIdOrDefault();

			if (entry.State == EntityState.Modified)
			{
				entry.Property(AuditableShadowProperties.ModifiedDateTime).CurrentValue = now;
				entry.Property(AuditableShadowProperties.ModifiedByUserId).CurrentValue = userId;
			}
			else if (entry.State == EntityState.Added)
			{
				entry.Property(AuditableShadowProperties.CreatedDateTime).CurrentValue = now;
				entry.Property(AuditableShadowProperties.CreatedByUserId).CurrentValue = userId;
			}
		}
	}
}
