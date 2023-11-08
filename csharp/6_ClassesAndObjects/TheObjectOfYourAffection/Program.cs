using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingProfile
{
    /*
    This program can create dating profiles.
    Leaving out your pronouns or hobbies is possible
    with the help of constructor overloading.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies = new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" };
            string[] hobbies2 = new String[] { "hobby1", "hobby2", "hobby3" };
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him", hobbies);
            Console.WriteLine(sam.ViewProfile());
            Profile max = new Profile("Max", 20, "Myyr York", "Finland");
            max.SetHobbies(hobbies2);
            Console.WriteLine(max.ViewProfile());
            Console.ReadLine();
        }
    }
}
