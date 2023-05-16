using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class FoodDelivery
    {
        static void Main(string[] args)
        {
            int chiken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double chikenPrice = chiken * 10.35;
            double fishPrise = fish * 12.40;
            double veganPrice = vegan * 8.15;
            double order = chikenPrice + fishPrise + veganPrice;

            double desert = order * 0.2;
            double delivery = 2.50;

            double total = order + desert + delivery;

            Console.WriteLine(total);

        }
    }
}