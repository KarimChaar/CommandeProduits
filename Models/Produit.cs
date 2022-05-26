using System.ComponentModel.DataAnnotations;

namespace CommandeProduct.Models
{

    public class Produit
    {

        [Key]
        public int id_P { get; set; }

        [Required]
        public string nom_P { get; set; }
        
        public int quantite { get; set; }

        public string marque { get; set; }

        public List<Commande> Commande { get; set; }

    }
}
