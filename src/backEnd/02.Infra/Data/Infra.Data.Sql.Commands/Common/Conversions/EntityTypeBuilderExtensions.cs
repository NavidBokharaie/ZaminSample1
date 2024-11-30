namespace Infra.Data.Sql.Commands.Common.Conversions;

public static class EntityTypeBuilderExtensions
{
    public static PropertyBuilder<decimal> HasFloatToDecimal(
        this PropertyBuilder<decimal> propertyBuilder)
    {

        return propertyBuilder
            .HasConversion(
                c => (double?)c, c => (decimal)Convert.ToSingle(c)
            );
    }
}
