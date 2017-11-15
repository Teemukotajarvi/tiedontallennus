using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Masterdetail.Models;

namespace Masterdetail.Controllers
{
    public class HenkilotController : Controller
    {
        // GET: Henkilot
        public ActionResult Index()
        {
            TestiTietokantaEntities entities = new TestiTietokantaEntities();

            try
            {
                List<Henkilot> model = entities.Henkilot.ToList();
                return View(model); 
            }
            finally
            {
                entities.Dispose();
            }
            
        }
    }
}