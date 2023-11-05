using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldValue = 10;
            int silverValue = 5;
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Which amount would you like to convert?");
            string input = Console.ReadLine();
            // With CultureInfo set to "en-US" we specify we use "." instead of "," for decimal numbers.
            double value = Math.Floor(Convert.ToDouble(input, CultureInfo.GetCultureInfo("en-US")));

            Console.WriteLine($"{value} cents is equal to...");
            double goldCoins = (Math.Floor(value / goldValue));
            double remainder = (value % goldValue);
            double silverCoins = (Math.Floor(remainder / silverValue));
            remainder = (remainder % silverValue);
            Console.WriteLine("Gold coins: " + goldCoins);
            Console.WriteLine("Silver coins: " + silverCoins);
            Console.WriteLine("Bronze coins: " + remainder);

            // Press Enter to exit.
            Console.ReadLine();
        }
    }
}
