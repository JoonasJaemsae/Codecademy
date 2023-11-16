using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which genre would you like to watch?");
            string genre = Console.ReadLine();

            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
            }
            Console.ReadLine();
        }
    }
}
