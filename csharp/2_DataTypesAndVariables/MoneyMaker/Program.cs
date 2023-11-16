using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program converts a numerical amount to coins.
            int goldValue = 10;
            int silverValue = 5;
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Which amount would you like to convert?");
            string input = Console.ReadLine();
            double value = Math.Floor(Convert.ToDouble(input));
            Console.WriteLine($"{value} cents is equal to...");
            double goldCoins = (Math.Floor(value / goldValue));
            double remainder = (value % goldValue);
            double silverCoins = (Math.Floor(remainder / silverValue));
            remainder = (remainder % silverValue);
            Console.WriteLine("Gold coins: " + goldCoins);
            Console.WriteLine("Silver coins: " + silverCoins);
            Console.WriteLine("Bronze coins: " + remainder);
            Console.ReadLine();
        }
    }
}
