using CommandeProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandeProduct.Data
{
    public class CPDbContext :DbContext
    {
        public CPDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=CommandProduit;Trusted_Connection=True;"); }
        public DbSet<Client> Clients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { modelBuilder.Entity<Client>().ToTable("Client"); }
    }
}
