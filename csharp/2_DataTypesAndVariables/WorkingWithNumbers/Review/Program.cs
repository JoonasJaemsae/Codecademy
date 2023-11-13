using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            DATA TYPES: int, double
            ARITHMETIC OPERATORS: +, -, *, /
            INCREMENT/DECREMENT: ++, --
            MODULO: % 
            BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

            Good luck! */

            /*
            Initialize these as doubles instead of ints so that Math.Floor() doesn't result in an error because the call is ambiguous.
            */
            double userAge = 32;
            double YearInDogYears = 7;

            double AgeInDogYears = Math.Floor(userAge / YearInDogYears);

            Console.WriteLine(AgeInDogYears);
            Console.ReadLine();
        }
    }
}
