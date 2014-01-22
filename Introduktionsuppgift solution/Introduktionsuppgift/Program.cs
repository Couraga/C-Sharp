using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFrequencyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] frequencyTable = null;

            count = ReadNumberOfRolls();

            frequencyTable = RollDie(count);

            ViewFrequencyTable(frequencyTable);
        }

        private static int ReadNumberOfRolls()
        {
            int count = 0;

            while (true)
            {
                try
                {
                    Console.Write("Ange antal tärningskast [100-1000]: ");
                    count = int.Parse(Console.ReadLine());
                    if (count < 100 || count > 1000)
                    {
                        throw new ApplicationException();
                    }
                    return count;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFel! Ange ett heltal mellan 100 och 1000. \n");
                    Console.ResetColor();
                }
            }
        }

        private static int[] RollDie(int count)
        {
            int[] frequencyTable = new int[6];
            Random die = new Random();
            for (int i = 0; i < count; i++)
            {
                frequencyTable[die.Next(0, 6)]++;
            }

            return frequencyTable;

        }

        private static void ViewFrequencyTable(int[] frequencyTable)
        {
            string[] facets = { "Ettor", "Tvåor", "Treor", "Fyror", "Femmor", "Sexor" };

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n----------------");
            Console.WriteLine("Frekvenstabell ");
            Console.WriteLine("----------------");

            for (int i = 0; i < facets.Length; i++)
            {
                Console.WriteLine("{0,-7}: {1,4}", facets[i], frequencyTable[i]);
                Console.WriteLine("----------------");
            }
        }

       
    }
}
