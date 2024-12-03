using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Banks.Entities;
using Infra.Data.Sql.Commands.Common.Extensions;

namespace Infra.Data.Sql.Commands.Banks.Configs;

public class BankConfig : IEntityTypeConfiguration<Bank>
{
	public void Configure(EntityTypeBuilder<Bank> builder)
	{
        builder.DisableShadowProperty();
		builder.ToTable("Banks", "dbo");
        builder.HasKey(e => e.Id);
		//builder.Property(c => c.Id).HasColumnName("ccBank");

builder.HasMany<Hesab>().WithOne().HasPrincipalKey(c => c.Id).HasForeignKey("BankId");
//EntityCommandConfigReplacementText
	}
}
