using JadooProject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.DataAccess.Context
{
    public class JadooContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERHAN\\SQLEXPRESS;database=JadooProjectDb;integrated security=true;trustServerCertificate=true");
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Service> Services { get; set; }


    }
}
