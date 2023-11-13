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
            // /* use this space to write your own short program! 
            // Here's what you learned:

            // DATA TYPES: char, string
            // STRING INTERPOLATION: $"blah blah"
            // STRING INFO: .Length, .IndexOf()
            // PARTS OF STRINGS: bracketNotation[], .Substring() 
            // STRING MANIPULATION: .ToUpper(), .ToLower()

            // Good luck! */

            /*
            The following program builds a new string from an existing string and randomly makes each character either uppercase or lowercase and then outputs the new string.
            */
            string randomcaseString = "The characters in this string are randomly uppercase or lowercase";

            var sb = new System.Text.StringBuilder();
            int length = randomcaseString.Length;
            int i = 0;
            string oneChar;
            Random rnd = new Random();
            int num;
            while (i < length)
            {
                num = rnd.Next(0, 2);
                if (num % 2 == 0)
                {
                    oneChar = randomcaseString.Substring(i, 1).ToUpper();
                    sb.Append(oneChar);
                }
                else
                {
                    oneChar = randomcaseString.Substring(i, 1).ToLower();
                    sb.Append(oneChar);
                }
                i++;
            }
            Console.WriteLine($"{sb}.");
            Console.ReadLine();
        }
    }
}
