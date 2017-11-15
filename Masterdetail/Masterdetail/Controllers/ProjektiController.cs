using Masterdetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Masterdetail.Controllers
{
    public class ProjektiController : Controller
    {
        // GET: Projekti
        public ActionResult Index()
        {
            TestiTietokantaEntities entities = new TestiTietokantaEntities();
            try
            {
                List<Projektit> model = entities.Projektit.ToList();
                return View(model);
            }
            finally
            {
                entities.Dispose();
            }
        }
            
            public ActionResult GetHourData(int id)
        {
            TestiTietokantaEntities entities = new TestiTietokantaEntities();
            try
            {
                List<Tunnit> Tunti = (from t in entities.Tunnit
                                      where t.Projekti_id == id
                                      orderby t.Pvm descending
                                      select t).ToList();
                StringBuilder html = new StringBuilder();
                html.Append("Hello World");

                var jsonData = new { html = html.ToString() };
                return Json(jsonData,JsonRequestBehavior.AllowGet);
            }
            finally
            {
                entities.Dispose();
            }
        }
    }
}