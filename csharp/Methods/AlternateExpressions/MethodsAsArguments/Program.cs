using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAsArguments
{
    class Program
    {
        public static bool IsLong(string word)
        {
            return word.Length > 8;
        }

        static void Main(string[] args)
        {
            // Array to be used as first argument
            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

            // Call Array.Find() and 
            // Pass in the array and method as arguments
            string firstLongAdjective = Array.Find(adjectives, IsLong);

            Console.WriteLine($"The first long word is: {firstLongAdjective}.");
            Console.ReadLine();
        }
    }
}
