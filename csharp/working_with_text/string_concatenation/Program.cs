using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables
            string beginning = "Once upon a time";
            string middle = "there was a C# course";
            string end = "until I finished it. The End.";

            // Concatenate the string and the variables
            string story = beginning + " " + middle + " " + end;

            // Print the story to the console 
            Console.WriteLine(story);
        }
    }
}
