using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
            Console.ReadLine();
        }

        // Replaced with a lambda expression.
        static bool HitGround(string s)
        {
            return s == "meteorite";
        }
    }
}
