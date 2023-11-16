using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            int nameAsInt;
            bool outcome;
            bool outcome2;

            outcome = Int32.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);

            // or outcome2 = Int32.TryParse(nameAsString, out int nameAsInt);
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);
            Console.ReadLine();
        }
    }
}
