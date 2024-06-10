using Horizons.Context.Models;
using System.Data.Entity;

namespace Horizons.Context
{
    public class HorizonsDbContext : DbContext
    {
        public HorizonsDbContext() : base("HorizonsDbConnectionString")
        {

        }

        public DbSet<Excursion> Excursions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<TourOrder> TourOrders { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Clients)
                .WithRequired(x => x.Client);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Managers)
                .WithRequired(x => x.Manager)
                .WillCascadeOnDelete(false);
        }
    }
}
