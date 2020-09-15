using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        // This constructor is used of nunit testing
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Cards> Cards { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<GroupShared> GroupShared { get; set; }
        public DbSet<CardFavorite> CardFavorite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("DataSource=app.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API configurations 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
