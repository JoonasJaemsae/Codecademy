using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The program determines if you can go to the beach
            with your friend on your vacation or not based on
            each one of your needs.
            */
            bool beach = true;
            bool hiking = false;
            bool city = true;
            bool yourNeeds = (beach && city);
            bool friendNeeds = (beach || hiking);
            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);
            Console.ReadLine();
        }
    }
}
