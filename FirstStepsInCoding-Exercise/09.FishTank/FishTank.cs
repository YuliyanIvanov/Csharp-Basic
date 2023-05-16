using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class FishTank
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine()); 
            double percent = double.Parse(Console.ReadLine());

            double volume = width * lenght * height;
            double bulk = volume / 1000;
            double size = percent / 100;
            double capacity = bulk * (1 - size);

            Console.WriteLine(capacity);
        }
    }
}
