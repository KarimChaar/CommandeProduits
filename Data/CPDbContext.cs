using CommandeProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandeProduct.Data
{
    public class CPDbContext :DbContext
    {
        public CPDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=CommandProduit;Trusted_Connection=True;"); }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Produit> Produits { get; set; }

        public DbSet<Commande> Commandes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {


            modelBuilder.Entity<Commande>()
                .HasOne(c => c.client)
                .WithMany(cmd => cmd.Commande)
                .HasForeignKey(c => c.Cin);
                

            modelBuilder.Entity<Commande>()
                 .HasOne(p => p.produit)
                 .WithMany(cmd => cmd.Commande)
                 .HasForeignKey(IdP => IdP.id_P);
        
        }
    }
}
