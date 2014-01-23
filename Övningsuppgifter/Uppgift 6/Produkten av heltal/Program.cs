using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkten_av_heltal
{
    class Program
    {
        static void Main(string[] args)
        {
            long produkt = 1;

            for (int i = 1; i <= 20; i++)
            {
                produkt *= i;
                
            }

            Console.WriteLine("Produkten av alla heltal mellan 1 och 20 är {0}.", produkt);
        }
    }
}
