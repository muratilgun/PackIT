using Microsoft.EntityFrameworkCore;
using PackIT.Infrastructure.EF.Models;

namespace PackIT.Infrastructure.EF.Contexts
{
    internal sealed class ReadDbContext : DbContext
    {
        public DbSet<PackingListReadModel> PackingLists { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("packing");
            base.OnModelCreating(modelBuilder);
        }
    }
}