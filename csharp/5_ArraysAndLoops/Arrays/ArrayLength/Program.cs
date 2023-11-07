using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "Pineapple Pen" };

            if (summerStrut.Length == 8)
            {
                Console.WriteLine("summerStrut Playlist is ready to go!");
            }
            else if (summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            else
            {
                Console.WriteLine("Add some songs!");
            }
        }
    }
}
