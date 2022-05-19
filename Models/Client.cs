using System.ComponentModel.DataAnnotations;

namespace CommandeProduct.Models
{
    public enum type { professionnel, particulier };

    /* public struct Adresse
       {
           public Adresse(string rue, string ville, string pays)
           {
               Rue = rue;
               Ville = ville;
               Pays = pays;
           }

           public Adresse()
           {
               Rue = "gggg";
               Ville = "ville";
               Pays = "pays";
           }

           public string Rue { get; set; }
           public string Ville { get; set; }
           public string Pays { get; set; }

       }*/
    public class Client
    {
      
        private string nom;

       // private Adresse location;

        private type type_C;

        public Client(string nom, string rue, string ville, string pays/*Adresse location*/, type type_C)
        {
            this.nom = nom;
           // this.location=new Adresse(location.Rue,location.Ville,location.Pays);
            this.LocationRue= rue;
            this.LocationVille= ville;
            this.LocationPays= pays;
            this.type_C = type_C;
        }

        public Client() { }
        [Key]
        public string Cin { get; set; }
        [Required(ErrorMessage =" Name is missing")]
        [StringLength(10,MinimumLength=3,ErrorMessage = "respect name length >2")]
        [DataType(DataType.Text)]
        public string ClientNom { get; set; }
        //public Adresse Location { get; set; }
        [Required(ErrorMessage = " street is missing")]
        [DataType(DataType.Text)]
        public string LocationRue { get; set; }
        [Required(ErrorMessage = " Town is missing")]
        [DataType(DataType.Text)]
        public string LocationVille { get; set; }
        [Required(ErrorMessage = " Country is missing")]
        [DataType(DataType.Text)]
        public string LocationPays { get; set; }
        [Required(ErrorMessage = "Type is missing")]
        [DataType(DataType.Text)]
        public type Type_C { get; set; }




    }
}
