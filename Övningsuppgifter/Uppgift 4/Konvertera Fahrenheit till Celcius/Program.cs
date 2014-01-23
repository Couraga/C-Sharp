using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konvertera_Fahrenheit_till_Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 0.0;
            double celcius = 0.0;

            Console.WriteLine("Ange temperaturen i grader Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celcius = (fahrenheit - 32)*5/9;

            Console.WriteLine("Temperaturen {0} °F motsvarar {1:f1} °C", fahrenheit, celcius);
        }
    }
}
