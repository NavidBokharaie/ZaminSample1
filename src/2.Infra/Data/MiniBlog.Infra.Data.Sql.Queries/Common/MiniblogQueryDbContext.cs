using Microsoft.EntityFrameworkCore;
using MiniBlog.Infra.Data.Sql.Queries.Common.Models;
using Zamin.Infra.Data.Sql.Queries;

namespace MiniBlog.Infra.Data.Sql.Queries.Common
{
    public partial class MiniblogQueryDbContext : BaseQueryDbContext
    {
        public MiniblogQueryDbContext(DbContextOptions<MiniblogQueryDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }

        public virtual DbSet<OldTable1> OldTable1s { get; set; }

        public virtual DbSet<OutBoxEventItem> OutBoxEventItems { get; set; }

        public virtual DbSet<ParrotTranslation> ParrotTranslations { get; set; }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
                entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
            });

            modelBuilder.Entity<OldTable1>(entity =>
            {
                entity.HasKey(e => e.CcOldTable1);

                entity.Property(e => e.CcOldTable1).HasColumnName("ccOldTable1");
            });

            modelBuilder.Entity<OutBoxEventItem>(entity =>
            {
                entity.ToTable("OutBoxEventItems", "zamin");

                entity.Property(e => e.AccuredByUserId).HasMaxLength(255);
                entity.Property(e => e.AggregateName).HasMaxLength(255);
                entity.Property(e => e.AggregateTypeName).HasMaxLength(500);
                entity.Property(e => e.EventName).HasMaxLength(255);
                entity.Property(e => e.EventTypeName).HasMaxLength(500);
                entity.Property(e => e.SpanId).HasMaxLength(100);
                entity.Property(e => e.TraceId).HasMaxLength(100);
            });

            modelBuilder.Entity<ParrotTranslation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__ParrotTr__3214EC07AACFF4B2");

                entity.HasIndex(e => e.BusinessId, "UQ__ParrotTr__F1EAA36F9E9D654A").IsUnique();

                entity.Property(e => e.BusinessId).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Culture).HasMaxLength(5);
                entity.Property(e => e.Key).HasMaxLength(255);
                entity.Property(e => e.Value).HasMaxLength(500);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
                entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
            });
        }

    }
}
