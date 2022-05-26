using CommandeProduct.Data;
using Microsoft.EntityFrameworkCore;

namespace CommandeProduct.Models
{
    public class Repository
    {
        private static List<Client> listeClients = new List<Client>();
        private static List<Produit> listeProduits = new List<Produit>();
        private static List<Commande> listeCommandes = new List<Commande>();

        public static object ViewBag { get; private set; }


        //------------------------------Client part -----------------------------




        public static IEnumerable<Client> getAllClients()
        {
            CPDbContext db = new CPDbContext();
            listeClients = db.Clients.ToList();
            return listeClients;
        }

        public static void addClient(Client c)
        {
            if (c.Cin.Equals(""))
            {
                CPDbContext db = new CPDbContext();
                db.Clients.Add(c);
                db.SaveChanges();
            }
            else
            {
                CPDbContext db = new CPDbContext();
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void deleteClient(string id)
        {
            CPDbContext db = new CPDbContext();
            Client c = db.Clients.Find(id);
            db.Clients.Remove(c);
            db.SaveChanges();
        }

//--------------------------Product Part--------------------------
        public static IEnumerable<Produit> getAllProducts()
        {
            CPDbContext context = new CPDbContext();
            listeProduits = context.Produits.ToList();
            return listeProduits;
        }

        public static void AddOrUpdateProduit(Produit p)
        {
            CPDbContext context = new CPDbContext();
            if (p.id_P.Equals(0))
            {
                context.Produits.Add(p);
                context.SaveChanges();
            }
            else
            {
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void deleteProduit(int id)
        {
            CPDbContext db = new CPDbContext();
            Produit p = db.Produits.Find(id);
            db.Produits.Remove(p);
            db.SaveChanges();
        }

//-------------------------Commande part-----------------------

        public static void deleteCommande(int id)
        {
            CPDbContext context=new CPDbContext();
            Commande c = context.Commandes.Find(id);
            context.Commandes.Remove(c);
            context.SaveChanges();
        }

        public static List<Commande> getAllCommands()
        {
            CPDbContext context = new CPDbContext();
            listeCommandes = context.Commandes.ToList();
            return listeCommandes;
        }

        public static void AddOrUpdateCommande(Commande c)
        {
            CPDbContext context = new CPDbContext();
            if (c.Id_Command.Equals(0))
            {
                context.Commandes.Add(c);
                context.SaveChanges();
            }
            else
            {
                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
