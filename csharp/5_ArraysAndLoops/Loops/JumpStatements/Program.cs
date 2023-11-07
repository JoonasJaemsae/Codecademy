using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // The alarm will ring 3 times.
            bool buttonClick = false;
            int counter = 0;

            do
            {
                Console.WriteLine("BLARRRRR");
                counter++;
                if (counter >= 3)
                {
                    break;
                }

            } while (!buttonClick);
            Console.ReadLine();
        }
    }
}
