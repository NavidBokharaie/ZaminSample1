using Infra.Data.Sql.Queries.Common.Models;

namespace Infra.Data.Sql.Queries.Common;

public partial class ZaminSample1QueryDbContext : BaseQueryDbContext
{
    public ZaminSample1QueryDbContext(DbContextOptions<ZaminSample1QueryDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Test> Tests { get; set; }
    //SqlQueriesQueryDbContextDbSet

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}