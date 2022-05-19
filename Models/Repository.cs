using CommandeProduct.Data;
using Microsoft.EntityFrameworkCore;

namespace CommandeProduct.Models
{
    public class Repository
    {
        private static List<Client> listeClients = new List<Client>();

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
    }
}
