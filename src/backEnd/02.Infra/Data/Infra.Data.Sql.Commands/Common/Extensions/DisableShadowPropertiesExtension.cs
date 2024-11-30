using Infra.Data.Sql.Commands.Common.AuditableShadowProperty;
using Zamin.Infra.Data.Sql.Commands.Extensions;

namespace Infra.Data.Sql.Commands.Common.Extensions;

public static class DisableShadowPropertiesExtension
{
    public static EntityTypeBuilder<TEntity> DisableShadowProperty<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : class
    {
        builder.Ignore(AuditableShadowProperties.CreatedByUserId);
        builder.Ignore(AuditableShadowProperties.ModifiedByUserId);
        builder.Ignore(AuditableShadowProperties.CreatedDateTime);
        builder.Ignore(AuditableShadowProperties.ModifiedDateTime);

        ExcludedAggregateShadowProperty.AddExcludedAggregate(typeof(TEntity));
        return builder;
    }
}