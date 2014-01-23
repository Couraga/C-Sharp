using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubbelt_upp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 23, 5, 1, 15 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.WriteLine();

            int temp = numbers[1];
            temp = temp * 2;
            numbers[1] = temp;

            temp = numbers[4];
            temp = temp * 2;
            numbers[4] = temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.WriteLine();
        }
    }
}
