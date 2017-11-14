using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestiTietokantaWebApp.Models;

namespace TestiTietokantaWebApp.Controllers
{
    public class HenkiloController : Controller
    {
        // GET: Henkilo
        public ActionResult Index()
        {
            TestiTietokantaEntities entities = new TestiTietokantaEntities();
            List<Henkilot> model = entities.Henkilot.ToList();
            entities.Dispose();

            return View(model);
        }
    }
}