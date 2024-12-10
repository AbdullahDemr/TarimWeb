using Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=94.73.145.4;Database=u1638900_EkinTar;User ID=u1638900_Ekintar;Password=q17u82TwFsA:P@._;TrustServerCertificate=true;");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
