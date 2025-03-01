using Microsoft.EntityFrameworkCore;

namespace _3_12_.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<lab12> Laba {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ZZZEDITGOJO\MSSQLSERVER01;Database=12;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
