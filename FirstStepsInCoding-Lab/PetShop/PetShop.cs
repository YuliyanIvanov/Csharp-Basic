using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInCodingLab
{
    internal class PetShop
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double dogPrice = dogFood * 2.50;
            double catPrice = catFood * 4;
            double total = dogPrice + catPrice;

            Console.WriteLine($"{total} lv.");
        }
    }
}