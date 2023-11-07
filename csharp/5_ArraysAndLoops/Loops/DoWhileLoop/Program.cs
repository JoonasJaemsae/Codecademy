using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buttonClick = true;
            do
            {
                Console.WriteLine("BLARRRRRRRRR");
            } while (!buttonClick);
            Console.WriteLine("Time for a five minute break.");
            Console.ReadLine();
        }
    }
}
