using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Masterdetail.Models;
using System.Text;

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
            public ActionResult GetOrderData(int id)
        {
            TestiTietokantaEntities entities = new TestiTietokantaEntities();           
            try
            {               
                  List <Tunnit> Tunti = (from t in entities.Tunnit
                                       where t.Henkilo_id == id
                                       orderby t.Pvm
                                       descending
                                       select t).ToList();

                StringBuilder html = new StringBuilder();
                html.Append("Hello World");
               
                var jsonData = new { html = html.ToString() };
                return Json(jsonData, JsonRequestBehavior.AllowGet);
            }
            finally
            {
                entities.Dispose();
            }
        }
    }
}