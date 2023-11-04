using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program will output a funny story that takes in words from the user.
            Author: Joonas
            */

            // Let the user know that the program is starting:
            Console.WriteLine("The program has started, FYI.");

            // Give the Mad Lib a title:
            string title = "A Cool Story for Bros and all the Bro-minded";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter an adjective you like: ");
            string adj1 = Console.ReadLine();
            Console.Write("Let's hear some more. Hit me with a second adjective of your liking: ");
            string adj2 = Console.ReadLine();
            Console.Write("And what's your third favourite adjective: ");
            string adj3 = Console.ReadLine();
            Console.Write("We're going to need one verb as well: ");
            string verb = Console.ReadLine();
            Console.Write("Next up: nouns! Enter a noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("And one more noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Give me an animal! ");
            string animal = Console.ReadLine();
            Console.Write("A food! ");
            string food = Console.ReadLine();
            Console.Write("A fruit! ");
            string fruit = Console.ReadLine();
            Console.Write("A superhero! ");
            string superhero = Console.ReadLine();
            Console.Write("A country! ");
            string country = Console.ReadLine();
            Console.Write("A dessert! ");
            string dessert = Console.ReadLine();
            Console.Write("A year! ");
            string year = Console.ReadLine();
            Console.Write("Whew! Sorry about that, but that was some good exercise, right? Press enter and I'll tell you a story!");
            Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);
            Console.ReadLine();
        }
    }
}
