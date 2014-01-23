using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finn_Fem_Fel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn fem fel";

            int hours = 35;
            double hourlyWages = 173.27;
            double weeklyWages = hours * hourlyWages;

            Console.WriteLine("Veckolönen är {0:c}.\n", weeklyWages);

        }
    }
}
