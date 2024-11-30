using Core.Domain.Tests.Entities;

namespace Infra.Data.Sql.Commands.Tests.Configs;

public class TestConfig : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.ToTable("Tests", "dbo");
        //builder.Property(c => c.Id).HasColumnName("ccTest");

        //builder.DisableShadowProperty();
    }
}
