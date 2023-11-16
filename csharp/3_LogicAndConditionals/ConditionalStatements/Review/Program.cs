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

            CONDITIONALS: if, if...else, else if
            SWITCH STATEMENT: switch (condition)
            TERNARY OPERATOR: (condition) ? true : false

            Good luck! */

            /*
            The program has the user pick a number between 1 and 10
            and tells them if it was the same the program picked
            and lets them guess again if not. If the user guesses
            the number correctly, the program reveals itself to be
            Fonzie from the sitcom Happy Days.
            */

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);

            Console.WriteLine("Guess a number between 1 and 10");
            string guess = Console.ReadLine();
            int num = Convert.ToInt32(guess);
            while (num != randomNumber)
            {
                if (num < randomNumber)
                {
                    Console.WriteLine("Higher! Guess again.");
                    guess = Console.ReadLine();
                    num = Convert.ToInt32(guess);
                }
                else
                {
                    Console.WriteLine("Lower! Guess again.");
                    guess = Console.ReadLine();
                    num = Convert.ToInt32(guess);
                }
            }
            Console.WriteLine("Correctamundo!");
            Console.ReadLine();
        }
    }
}
