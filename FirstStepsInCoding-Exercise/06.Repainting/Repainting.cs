using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class Repainting
    {
        static void Main(string[] args)
        {
            int covers = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double coversPrice = (covers + 2) * 1.50;
            double paintPrice = (paint + (0.1 * paint)) * 14.50;
            double diluentPrise = diluent * 5;
            double bags = 0.40;

            double allMaterials = coversPrice + paintPrice + diluentPrise + bags;
            double workersPay = (allMaterials * 0.30) * 8;

            double total = allMaterials + workersPay;

            Console.WriteLine(total);
        }
    }
}
