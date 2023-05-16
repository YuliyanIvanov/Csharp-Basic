using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class DepositCalculator
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());    
            int time = int.Parse(Console.ReadLine());
            double intrestPercent = double.Parse(Console.ReadLine());

            double increaseIntrest = (deposit * (intrestPercent / 100)) / 12;
            double total = deposit + (time * increaseIntrest);

            Console.WriteLine($"{total:f2}");
        }
    }
}