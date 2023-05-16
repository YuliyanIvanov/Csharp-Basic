using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInCodingLab
{
    internal class YardGreening
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = price * 0.18;
            double total = price - discount;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}