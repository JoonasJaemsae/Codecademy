using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            // 1
            // foreach(var lang in languages)
            // {
            //   Console.WriteLine(lang.Prettify());
            // }

            // 2
            // var languagesAsString = languages.Select(lang => $"{lang.Year}, {lang.Name}, {lang.ChiefDeveloper}");

            // foreach(var lang in languagesAsString)
            // {
            //   Console.WriteLine(lang);
            // }

            // 3
            // var csharpLangs = from lang in languages
            //   where lang.Name.Contains("C#")
            //   select lang;

            // foreach(var lang in csharpLangs)
            // {
            //   Console.WriteLine(lang.Prettify());
            // }

            // 4
            // var langsByMicrosoft = from lang in languages
            //   where lang.ChiefDeveloper.Contains("Microsoft")
            //   select lang;

            // foreach(var lang in langsByMicrosoft)
            // {
            //   Console.WriteLine(lang.Prettify());
            // }

            // 5
            // var langsFromLisp = languages
            // .Where(lang => lang.Predecessors.Contains("Lisp"))
            // // .Select(lang => lang)
            // ;

            // foreach(var lang in langsFromLisp)
            // {
            //   Console.WriteLine(lang.Prettify());
            // }

            // 6
            // var langsWithScript = languages
            // .Where(lang => lang.Name.Contains("Script"));

            // foreach(var lang in langsWithScript)
            // {
            //   Console.WriteLine(lang.Prettify());
            // }

            // 7
            // Console.WriteLine(languages.Count);

            // 8
            // var langsFrom1995To2005 = languages
            // .Where(lang => lang.Year >= 1995 && lang.Year <= 2005);

            // Console.WriteLine(langsFrom1995To2005.Count());

            // 9
            // var langsFrom1995To2005 = languages
            // .Where(lang => lang.Year >= 1995 && lang.Year <= 2005)
            // .Select(lang => $"{lang.Name} was invented in {lang.Year}");

            // foreach(var lang in langsFrom1995To2005)
            // {
            //   Console.WriteLine(lang);
            // }

            // 10
            // PrettyPrintAll(languages);

            // 11
            // var langsFrom1995To2005 = languages
            // .Where(lang => lang.Year >= 1995 && lang.Year <= 2005)
            // .Select(lang => $"{lang.Name} was invented in {lang.Year}");

            // PrintAll(langsFrom1995To2005);

            // 12 Finding the oldest language
            var oldestLanguage = languages
            .Where(lang => lang.Year == (languages.Min(lang2 => lang2.Year)))
            .Select(lang => $"{lang.Name} was invented in {lang.Year} and is among the oldest languages on the list.");

            PrintAll(oldestLanguage);

            Console.ReadLine();
        }

        static void PrettyPrintAll(IEnumerable<Language> languages)
        {
            foreach (Language lang in languages)
            {
                Console.WriteLine(lang.Prettify());
            }
        }

        static void PrintAll(IEnumerable<Object> results)
        {
            foreach (Object res in results)
            {
                Console.WriteLine(res);
            }
        }
    }
}
