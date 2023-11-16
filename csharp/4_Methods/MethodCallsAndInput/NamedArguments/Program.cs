using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(numberOfPlanets: 2, name: "Joonas");
            Console.ReadLine();
        }

        static void VisitPlanets(
          string adjective = "brave",
          string name = "Cosmonaut",
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }
    }
}
