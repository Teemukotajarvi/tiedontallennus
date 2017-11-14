using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SqlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        { 
            string connStr = "Server=tcp:teemuko.database.windows.net,1433;"+
                "Initial Catalog=TestiTietokanta;Persist Security Info=False;User ID=Administratori;"+
                "Password=Cuccumia123;MultipleActiveResultSets=False;Encrypt=True;"+
                "TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM henkilot WHERE Etunimi = 'Juha'";

            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string Etunimi = reader.GetString(1);
                string Sukunimi = reader.GetString(2);
                MessageBox.Show("Löytyi rivi: " + Etunimi + " " + Sukunimi);
            }

            //resurssien vapautus.
            reader.Close();
            cmd.Dispose();
            conn.Dispose();


        }
    }
}
