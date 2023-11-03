using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} {middle}. {end}";

            // Print the story to the console 
            Console.WriteLine(story);
        }
    }
}
