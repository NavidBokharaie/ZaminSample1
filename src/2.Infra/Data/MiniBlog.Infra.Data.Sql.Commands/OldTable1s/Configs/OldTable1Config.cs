using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBlog.Core.Domain.OldTable1s.Entities;
using MiniBlog.Infra.Data.Sql.Commands.Common.AuditableShadowProperty.Extensions;

namespace MiniBlog.Infra.Data.Sql.Commands.OldTable1s.Configs
{
    public class OldTable1Config : IEntityTypeConfiguration<OldTable1>
	{
		public void Configure(EntityTypeBuilder<OldTable1> builder)
		{
			builder.ToTable("OldTable1s");
			builder.Property(c => c.Id).HasColumnName("ccOldTable1");

			builder.DisableShadowProperty();
		}
	}
}
