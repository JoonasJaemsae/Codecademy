using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
    class Program
    {
        static void Main()
        {
            string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            // Method syntax
            var introuceableHeroes = heroes.Select(h => $"Introducing...{h}!");

            // Query syntax
            var indicesOfSpace = from h in heroes
                          where h.Contains(" ")
                          select h.IndexOf(" ");
        
            // Printing...
            foreach (var hero in introuceableHeroes)
            {
                Console.WriteLine(hero);
            }
            Console.WriteLine();
            foreach (var index in indicesOfSpace)
            {
                Console.WriteLine(index);
            }
            Console.ReadLine();
        }
    }
}
