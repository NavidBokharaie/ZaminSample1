using Core.Domain.Banks.Entities;
using Infra.Data.Sql.Commands.Common.Extensions;

namespace Infra.Data.Sql.Commands.Banks.Configs;

public class HesabConfig : IEntityTypeConfiguration<Hesab>
{
    public void Configure(EntityTypeBuilder<Hesab> builder)
    {
        builder.DisableShadowProperty();
        builder.ToTable("Hesabs", "dbo");
        builder.HasKey(e => e.Id);
		//builder.Property(c => c.Id).HasColumnName(""ccHesab"");
    }
}
