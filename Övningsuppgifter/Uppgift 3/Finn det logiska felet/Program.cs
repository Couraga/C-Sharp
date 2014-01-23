using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finn_det_logiska_felet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn det logiska felet";

            int rate = 25;

            double cost = 0d;
            double tax = 0d;
            double totalCost = 0d;

            Console.Write("Ange varans pris exkl. moms: ");
            cost = Double.Parse(Console.ReadLine());

            tax = rate / 100d * cost;

            totalCost = cost + tax;

            Console.WriteLine("Varans pris inkl. moms är {0:c}.", totalCost);
        }
    }
}