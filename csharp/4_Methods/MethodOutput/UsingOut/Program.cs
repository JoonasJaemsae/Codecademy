using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "GARRRR";
            Console.WriteLine(Whisper(statement, out bool marker));
            Console.WriteLine(marker);
            Console.ReadLine();
        }

        static string Whisper(string param1, out bool param2)
        {
            param2 = true;
            return param1.ToLower();
        }
    }
}
