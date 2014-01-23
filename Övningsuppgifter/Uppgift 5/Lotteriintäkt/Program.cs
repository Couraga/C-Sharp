using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotteriintäkt
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;

            for (int i = 0; i <= 100; i = i + 2)
            {
                summa = summa + i;
            }

            Console.WriteLine("Ringen med lotter ger intäkten {0:c}.\n", summa);
        }
    }
}
