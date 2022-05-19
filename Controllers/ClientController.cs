using CommandeProduct.Models;
using Microsoft.AspNetCore.Mvc;
using CommandeProduct.Data;

namespace CommandeProduct.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult Client()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AllClients()
        {
            return View(Repository.getAllClients());
        }
        [HttpPost]
        public IActionResult Client(Client c)
        {
            Repository.addClient(c);
            return View("ConfirmPage", c);
        }
    }
}
