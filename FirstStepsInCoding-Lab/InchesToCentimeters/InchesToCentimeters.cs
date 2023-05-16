using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInCodingLab
{
    internal class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cantimeters = inches * 2.54;

            Console.WriteLine(cantimeters);
        }

    }
}
