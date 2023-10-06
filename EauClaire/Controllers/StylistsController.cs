using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClaire.Models;
using System.Collections.Generic;
using System.Linq;

namespace EauClaire.Controllers
{
    public class StylistsController : Controller
    {
        private readonly EauClaireContext _db;
        public StylistsController(EauClaireContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }
    }
}