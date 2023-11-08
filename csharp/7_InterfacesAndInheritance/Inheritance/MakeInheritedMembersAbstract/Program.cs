﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);

            Truck t = new Truck(45, 500);

            Bicycle b = new Bicycle(10);

            Console.WriteLine(s.Describe());
            Console.WriteLine(t.Describe());
            Console.WriteLine(b.Describe());
            Console.ReadLine();
        }
    }
}
