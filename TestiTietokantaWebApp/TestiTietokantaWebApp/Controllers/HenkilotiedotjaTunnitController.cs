using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestiTietokantaWebApp.Controllers
{
    public class HenkilotiedotjaTunnitController : Controller
    {
        // GET: HenkilotiedotjaTunnit
        public ActionResult Henkilo()
        {
            string connStr = "Server=tcp:teemuko.database.windows.net,1433;" +
                   "Initial Catalog=TestiTietokanta;Persist Security Info=False;User ID=Administratori;" +
                   "Password=Cuccumia123;MultipleActiveResultSets=False;Encrypt=True;" +
                   "TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM henkilot WHERE Etunimi = 'Juha'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string Etunimi = reader.GetString(1);
                string Sukunimi = reader.GetString(2);
                

                //resurssien vapautus.
                reader.Close();
                cmd.Dispose();
                conn.Dispose();
                return View(Etunimi + Sukunimi);
            }
        }
    }
}