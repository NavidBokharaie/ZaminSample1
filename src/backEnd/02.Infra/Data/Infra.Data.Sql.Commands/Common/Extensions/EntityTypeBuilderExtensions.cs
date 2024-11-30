namespace Infra.Data.Sql.Commands.Common.Extensions;

public static class EntityTypeBuilderExtensions
{
    public static PropertyBuilder<decimal> ConvertFloatToDecimal(
        this PropertyBuilder<decimal> propertyBuilder)
    {

        return propertyBuilder
            .HasConversion(
                c => (double?)c, c => (decimal)Convert.ToSingle(c)
            );
    }
    public static PropertyBuilder<decimal?> ConvertFloatToDecimalNullable(
        this PropertyBuilder<decimal?> propertyBuilder)
    {

        return propertyBuilder
            .HasConversion(
                c => (double?)c, c => (decimal)Math.Round(c ?? 0, 15)

            );
    }
}
