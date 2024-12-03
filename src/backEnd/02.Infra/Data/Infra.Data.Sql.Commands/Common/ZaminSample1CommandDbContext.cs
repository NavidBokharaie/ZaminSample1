using Core.Domain.Persons.Entities;
using Core.Domain.Tests.Entities;
using Infra.Data.Sql.Commands.Common.Extensions;
using Infra.Data.Sql.Commands.Common.OutboxEventItems;
using Zamin.Extensions.Events.Abstractions;
using Zamin.Infra.Data.Sql.Commands;
using Core.Domain.Banks.Entities;
//SqlCommandsCommandDbContextUsing

namespace Infra.Data.Sql.Commands.Common;

public partial class ZaminSample1CommandDbContext : BaseCommandDbContext
{
    #region Constructors
    public ZaminSample1CommandDbContext(DbContextOptions<ZaminSample1CommandDbContext> options) : base(options)
    {
    }

    #endregion

    #region DbSets
    public DbSet<OutBoxEventItem> OutBoxEventItems { get; set; }
    public DbSet<Test> Tests { get; set; }
            public DbSet<Person> Persons { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Hesab> Hesabs { get; set; }
//SqlCommandsCommandDbContextDbSet
    #endregion

    #region overrides

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        builder.HasDefaultSchema("dbo");

        builder.IgnoreBusinessId();
        builder.ApplyConfiguration(new OutBoxEventItemConfig("dbo"));

    }
    #endregion
}