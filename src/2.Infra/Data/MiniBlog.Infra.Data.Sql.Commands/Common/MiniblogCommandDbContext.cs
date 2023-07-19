using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Domain.Blogs.Entities;
using MiniBlog.Core.Domain.OldTable1s.Entities;
using MiniBlog.Core.Domain.People.Entities;
using Zamin.Extensions.Events.Outbox.Dal.EF;
using Zamin.Infra.Data.Sql.Commands.Extensions;

namespace MiniBlog.Infra.Data.Sql.Commands.Common
{
	public class MiniblogCommandDbContext : BaseOutboxCommandDbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Person> People { get; set; }
		public DbSet<OldTable1> OldTable1s { get; set; }
		public MiniblogCommandDbContext(DbContextOptions<MiniblogCommandDbContext> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.AddAuditableShadowProperties();
			builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
		}
	}
}
