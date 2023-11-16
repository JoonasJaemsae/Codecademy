using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            BOOL TYPE: bool variableName
            COMPARISON OPERATORS: ==, <, >, <=, >=
            LOGICAL OPERATORS: &&, ||, !

            Good luck! */

            /*
            The program checks a password if it has uppercase letters but doesn’t include symbols, and returns a truth value accordingly.
            */
            string password1 = "asdfGHJK";
            string password2 = "qwerTYUI!";

            bool containsUpper = false;
            bool containsSymbols = false;
            bool pass = false;
            var regexItem = new Regex("^[a-zA-Z0-9]*$");

            containsUpper = password1.Any(char.IsUpper);
            containsSymbols = regexItem.IsMatch(password1);

            pass = (containsUpper && containsSymbols);
            Console.WriteLine(pass);

            containsUpper = password2.Any(char.IsUpper);
            containsSymbols = regexItem.IsMatch(password2);

            pass = (containsUpper && containsSymbols);
            Console.WriteLine(pass);
            Console.ReadLine();
        }
    }
}
