using System;
using System.Collections.Generic;
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

namespace EntityDemo
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
            TestiTietokantaEntities entities = new TestiTietokantaEntities();

            var Esimies = from h in entities.Henkilot
                              where h.Esimies == 3
                              select h;

            foreach (var henk in Esimies)
            {
                MessageBox.Show(henk.Etunimi + " " + henk.Sukunimi);
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[] numerot = { 5, 23, 57, 4, 36, 2 };
            // suurempi kuin 5, tulokset lajiteltuna
            // vrt.SELECT luku FROM numerot WHERE luku > 5 ORDER BY luku

            var suuretNumerot = from n in numerot
                                where n > 5
                                orderby n
                                select n;

            foreach (var numero in suuretNumerot) 
            {
                MessageBox.Show(numero.ToString());
            }
        }
    }
}
