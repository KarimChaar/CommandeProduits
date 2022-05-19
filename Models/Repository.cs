using CommandeProduct.Data;

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
            CPDbContext db = new CPDbContext();
            db.Clients.Add(c);
            db.SaveChanges();
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
