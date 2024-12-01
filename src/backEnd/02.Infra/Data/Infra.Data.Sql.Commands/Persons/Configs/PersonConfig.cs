using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Persons.Entities;
using Infra.Data.Sql.Commands.Common.Extensions;

namespace Infra.Data.Sql.Commands.Persons.Configs;

public class PersonConfig : IEntityTypeConfiguration<Person>
{
	public void Configure(EntityTypeBuilder<Person> builder)
	{
        builder.DisableShadowProperty();
		builder.ToTable("Persons", "dbo");
        builder.HasKey(e => e.Id);
		//builder.Property(c => c.Id).HasColumnName("ccPerson");

//EntityCommandConfigReplacementText
	}
}
