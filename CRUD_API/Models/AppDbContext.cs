using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(){}
        public AppDbContext(DbContextOptions options) : base(options){}
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SHANGHAIK;Initial Catalog=API_SD18318_HL;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
