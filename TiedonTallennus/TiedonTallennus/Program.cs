using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "C:\\temp\\Lämpötila.txt";

            // luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("aiemmin asetettu lämpötila on " + aiempiArvo + " astetta. ");
            }
            else
            {
                Console.WriteLine("Tervee");
            }


            int lämpötila = 0;
            Console.WriteLine("Anna uusi lämpötila");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
            
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("uusi lämpötila tallennettu.");
            Console.ReadLine();

        }
    }
}
