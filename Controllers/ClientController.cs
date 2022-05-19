using CommandeProduct.Models;
using Microsoft.AspNetCore.Mvc;
using CommandeProduct.Data;
using System.Net;

namespace CommandeProduct.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult Client(Client x)
        {
            return View();
        }
        [HttpGet]
        public IActionResult AllClients()
        {
            return View(Repository.getAllClients());
        }
        [HttpPost]
        public IActionResult addClient(Client c)
        {
            
               Repository.addClient(c);
               return View("ConfirmPage", c);
            
 
        }

        /*public IActionResult updateClient(string id)
        {
            CPDbContext db = new CPDbContext();
            Client c=db.Clients.Find(id);

            return RedirectToAction("Client");
        }*/

        [HttpPost]
        public IActionResult Delete(string id)
        {
            Repository.deleteClient(id);
            return RedirectToAction("AllClients");
        }
    }

}
