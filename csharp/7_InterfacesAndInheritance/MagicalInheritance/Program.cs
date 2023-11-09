using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s = new Storm("wind", false, "Zul'rajas");

            Console.WriteLine(s.Announce());

            Pupil p = new Pupil("Mezil-Kree");
            Storm s2 = p.CastWindStorm();
            Console.WriteLine(s2.Announce());

            Mage m = new Mage("Gul'dan");
            Storm s3 = m.CastWindStorm();
            Storm s4 = m.CastRainStorm();
            Console.WriteLine(s3.Announce());
            Console.WriteLine(s4.Announce());

            Archmage a = new Archmage("Nielas Aran");
            Storm s5 = a.CastWindStorm();
            Storm s6 = a.CastRainStorm();
            Storm s7 = a.CastLightningStorm();
            Console.WriteLine(s5.Announce());
            Console.WriteLine(s6.Announce());
            Console.WriteLine(s7.Announce());
            Console.ReadLine();
        }
    }
}