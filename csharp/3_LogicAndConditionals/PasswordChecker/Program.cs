using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#£¤$%&{}[]()=?+-";
            int score = 0;

            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();
            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            Console.Write($"{score}: ");
            switch (score)
            {
                case int n when (n >= 4):
                    Console.WriteLine("Your password is extremely strong.");
                    break;
                case 3:
                    Console.WriteLine("Your password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Your password is weak.");
                    break;
                default:
                    Console.WriteLine("Your password does not meet any of the standards of a good password.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
