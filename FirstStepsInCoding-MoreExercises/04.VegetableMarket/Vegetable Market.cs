using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class VegetableMarket
    {
        private static void Main(string[] args)
        {
            double vegatablesKg = double.Parse(Console.ReadLine());
            double fruitsKg = double.Parse(Console.ReadLine());
            int totalKgVegetables = int.Parse(Console.ReadLine());  
            int totalKgFruits = int.Parse(Console.ReadLine());

            double totalVegetables = vegatablesKg * totalKgVegetables;
            double totalFruits = fruitsKg * totalKgFruits;

            double totalInBGN = totalVegetables + totalFruits;
            double profitInEuro = totalInBGN / 1.94;


            Console.WriteLine($"{profitInEuro:f2}");
        }
    }
}