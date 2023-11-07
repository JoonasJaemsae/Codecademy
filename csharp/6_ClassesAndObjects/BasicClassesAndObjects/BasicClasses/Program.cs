using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");
            f.Trees = 0;

            Forest f2 = new Forest("Rendlesham");
            Console.WriteLine(f2.Biome);

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            Console.ReadLine();
        }
    }
}
