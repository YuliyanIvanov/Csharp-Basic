using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class CelsiusToFahrenheit
    {
        private static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"{fahrenheit:f2}");
        }
    }
}