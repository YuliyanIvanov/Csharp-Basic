using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInCodingLab
{
    internal class ProjectsCreation
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();   
            int project = int.Parse(Console.ReadLine());
            int time = project * 3;

            Console.WriteLine($"The architect {name} will need {time} hours to complete {project} project/s.");
        }
    }
}