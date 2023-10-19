using GameStoreWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                               new User(1, "admin", new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 }),
                                              new User(2, "user", new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 })
                                                         );
        }

    }
}
