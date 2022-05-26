using System.ComponentModel.DataAnnotations;

namespace CommandeProduct.Models
{
    public class Commande
    {   
        [Key]
        public int Id_Command { get; set; }
        public int id_P { get; set; }

        public Produit produit { get; set; }
        public string Cin { get; set; }
        public Client client { get; set; }

    }
}
