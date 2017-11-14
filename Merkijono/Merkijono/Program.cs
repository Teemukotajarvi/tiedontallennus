using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            //huono tapa
            string s = "ABS";
            for (int i = 0; i < 100000; i++)
            {
                s = s + "!";
            }
            //parempi tapa
            StringBuilder builder = new StringBuilder("ABS");
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("!");
            }
            s = builder.ToString();
        }
    }
}
