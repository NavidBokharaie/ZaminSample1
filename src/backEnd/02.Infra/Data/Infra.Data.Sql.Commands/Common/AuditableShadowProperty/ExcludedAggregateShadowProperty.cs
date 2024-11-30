namespace Infra.Data.Sql.Commands.Common.AuditableShadowProperty;

public static class ExcludedAggregateShadowProperty
{
    public static List<Type> ExcludedEntities { get; private set; } = new();

    internal static void AddExcludedAggregate(Type type)
    {
        ExcludedEntities.Add(type);
    }
}