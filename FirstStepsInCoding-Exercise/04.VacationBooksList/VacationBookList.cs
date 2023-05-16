using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSoftUni
{
    internal class VacationBookList
    {
        static void Main(string[] args)
        {
            int numberOfPages = int .Parse(Console.ReadLine());
            int pagesPherHour = int .Parse(Console.ReadLine()); 
            int days = int .Parse(Console.ReadLine());

            int totalPages = numberOfPages / pagesPherHour;
            int pagesPerDay = totalPages / days;

            Console.WriteLine(pagesPerDay);
        }
    }
}