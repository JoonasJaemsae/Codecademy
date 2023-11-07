using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            while loop: while(){..} 
            do...while loop: do{...}while();
            for loop: for(int i=0; i<x; i++){}
            foreach loop: foreach(int item in list){}
            jump statements: break, continue, return

            Good luck! */

            // The alarm rings three times after which the button is clicked.
            bool buttonClick = false;
            int counter = 0;

            do
            {
                Console.WriteLine("BLARRRRR");
                counter++;
                if (counter >= 3)
                {
                    buttonClick = true;
                }

            } while (!buttonClick);
            Console.ReadLine();
        }
    }
}
