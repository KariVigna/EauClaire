using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClaire.Models;
using System.Collections.Generic;
using System.Linq;

namespace EauClaire.Controllers
{
    public class ClientsController : Controller
    {
        private readonly EauClaireContext _db;
        public ClientsController(EauClaireContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Client> model = _db.Clients.ToList();
            return View(model);
        }
    }
}