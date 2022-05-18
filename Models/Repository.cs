namespace CommandeProduct.Models
{
    public class Repository
    {
        private static List<Client> listeClients = new List<Client>();

        public static IEnumerable<Client> getAllClients()
        {
            return listeClients;
        }

        public static void addClient(Client c)
        {
            listeClients.Add(c);
        }
    }
}
