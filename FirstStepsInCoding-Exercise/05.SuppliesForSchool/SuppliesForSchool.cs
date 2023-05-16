using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class SuppliesForSchool
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double cleaningSolution = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) /100;

            double pensPrise = pens * 5.80;
            double markersPrise = markers * 7.20;
            double cleaningSolutionPrise = cleaningSolution * 1.20;
            double allSupplies = pensPrise + markersPrise +  cleaningSolutionPrise;

            double dis = allSupplies - (allSupplies * discount);

            Console.WriteLine(dis);
        }
    }
}
