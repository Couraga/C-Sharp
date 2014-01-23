using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_a_to_z_and_vice_versa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ittererar 
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                //Skriver ut aA till zZ
                Console.Write("{0}{1} ", (char)(ch + 32), ch);
            }

            //Skriver ut en tom rad
            Console.WriteLine();
            
            for (char ch = 'Z'; ch >= 'A'; ch--)
            {
                //SKriver ut zZ till aA
                Console.Write("{0}{1} ", (char)(ch + 32), ch);
            }

            Console.WriteLine();

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                //SKriver ut A B C...Z
                Console.Write("{0} ", (char)ch);
            }
        }
    }
}
