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
                html.AppendLine("<td colspan=\"5\">" +
                  "<table class=\"table table-striped\">");

                foreach (Tunnit tunnit in Tunti)
                {
                    html.AppendLine("<tr><td>" +
                        tunnit.Pvm.Value.ToShortDateString() + "</td>" +
                        "<td>"+tunnit.Henkilo_id+"</td>"+
                        "<td>"+tunnit.Tunti_id+"</td>"+
                        "<td>"+tunnit.Projekti_id+"</td>"+
                        "<td>"+tunnit.Tunnit1+"</td></tr>");
                     
                }                 
                html.AppendLine("</table></td>");
                                      
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