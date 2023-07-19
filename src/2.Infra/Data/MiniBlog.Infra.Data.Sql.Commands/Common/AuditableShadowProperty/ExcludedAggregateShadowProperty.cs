namespace MiniBlog.Infra.Data.Sql.Commands.Common.AuditableShadowProperty;

public static class ExcludedAggregateShadowProperty
{
	// Define a list of entities that should skip SetAuditableEntityPropertyValues
	private static List<Type> _excludedEntities = new();
	public static List<Type> ExcludedEntities => _excludedEntities;

	internal static void AddExcludedAggregate(Type type)
	{
		_excludedEntities.Add(type);
	}
}