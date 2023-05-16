using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class TriangleArea
    {
        private static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double face = a * h / 2;

            Console.WriteLine($"{face:f2}");
        }
    }
}