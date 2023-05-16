using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class BasketballEquipment
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoes = tax - (0.4 * tax);
            double outfit = shoes - (0.2 * shoes);
            double ball = outfit / 4;
            double trinkets = ball / 5;

            double total = tax + shoes + ball + outfit + trinkets;

            Console.WriteLine(total);
        }
    }
}