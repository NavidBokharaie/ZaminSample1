namespace Infra.Data.Sql.Commands.Common.Extensions;

public static class BusinessIdExtensions
{
    public static ModelBuilder IgnoreBusinessId(this ModelBuilder builder)
    {

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var property = entityType.FindProperty("BusinessId");
            if (property != null)
            {
                // Directly using Fluent API to ignore the 'BusinessId' property
                builder.Entity(entityType.ClrType).Ignore("BusinessId");
            }
        }

        return builder;
    }
}
