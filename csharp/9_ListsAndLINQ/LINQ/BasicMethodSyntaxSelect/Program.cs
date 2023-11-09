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

            var lowerHeroesWithC = heroes.Where(h => h.Contains("c"));
            lowerHeroesWithC = lowerHeroesWithC.Select(h => h.ToLower());

            var sameResult = heroes.Where(h => h.Contains("c"))
              .Select(h => h.ToLower());

            foreach (string hero in lowerHeroesWithC)
            {
                Console.WriteLine(hero);
            }
            foreach (string hero in sameResult)
            {
                Console.WriteLine(hero);
            }
            Console.ReadLine();
        }
    }
}
