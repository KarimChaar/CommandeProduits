namespace CommandeProduct.Models
{
    public enum type { professionnel, particulier };
    public struct adresse
    {
        private string rue;
        private string ville;
        private string pays;
    }

    public class Client
    {
        private string nom;

        private adresse location;

        private type type_C;

        public Client(string nom, adresse location, type type_C)
        {
            this.nom = nom;
            this.location = location;
            this.type_C = type_C;
        }



        
    }
}
