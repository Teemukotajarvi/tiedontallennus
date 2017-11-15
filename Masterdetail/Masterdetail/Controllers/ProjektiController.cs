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
                html.AppendLine("<td colspan=\"5\">"+
                "<table class=\"table table-striped\">");

                foreach (Tunnit tunti in Tunti )
                {
                    html.AppendLine("<tr><td>" +
                        tunti.Pvm.Value.ToShortDateString() + "</td>" +
                        "<td>"+tunti.Tunti_id+"</td>" +
                        "<td>"+tunti.Projekti_id+"</td>" +
                        "<td>"+tunti.Tunnit1+"</td></tr>");
                }
                               
                 html.AppendLine("</table></td>");
            
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