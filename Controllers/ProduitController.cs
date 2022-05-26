using CommandeProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandeProduct.Controllers
{
    public class ProduitController : Controller
    {
        [HttpGet]
        public IActionResult Produit(Produit produit)
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AllProduct()
        {
            return View(Repository.getAllProducts());
        }
        
        
        [HttpPost]
        public IActionResult AddOrUpdateProduct(Produit p)
        {
            Repository.AddOrUpdateProduit(p);
            return RedirectToAction("AllProduct");
        }
        
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            Repository.deleteProduit(id);
            return RedirectToAction("AllProduct");
        }



    }
}
