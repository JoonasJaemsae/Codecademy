using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptureOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string designer = "Anders Hejlsberg";
            int indexOfSpace = designer.IndexOf(" ");
            string secondName = designer.Substring(indexOfSpace + 1, 9);
            Console.WriteLine(secondName);
            Console.ReadLine();
        }
    }
}
