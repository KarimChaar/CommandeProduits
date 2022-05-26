using CommandeProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandeProduct.Controllers
{
    public class CommandeController : Controller
    {
        public IActionResult Commande(Commande commande)
        {
            IEnumerable<Client> clients = new List<Client>();
            clients = Repository.getAllClients();
            IEnumerable<Produit> produits = new List<Produit>();
            produits = Repository.getAllProducts();
            Console.WriteLine(clients);
            return View();
        }

        public IActionResult AllCommands()
        {
            
            return View(Repository.getAllCommands());
        }

        public IActionResult AddOrUpdateCommande(Commande c)
        {
            Repository.AddOrUpdateCommande(c);
            return RedirectToAction("AllCommande");
        }

        public IActionResult DeleteCommande(int id)
        {
            Repository.deleteCommande(id);
            return RedirectToAction("AllCommande");
        }
    }
}
