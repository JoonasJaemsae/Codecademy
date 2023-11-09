using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] roverArray = new Rover[] { lunokhod, apollo, sojourner };

            DirectAll(roverArray);

            IDirectable[] oArray = new IDirectable[] { lunokhod, apollo, sojourner, sputnik };

            foreach (IDirectable obj in oArray)
            {
                Console.WriteLine($"Tracking a {obj.GetType()}.");
            }
            Console.ReadLine();
        }

        static void DirectAll(IDirectable[] roverArray)
        {
            foreach (Rover rover in roverArray)
            {
                Console.WriteLine(rover.GetInfo());
                Console.WriteLine(rover.Explore());
                Console.WriteLine(rover.Collect());
                Console.WriteLine();
            }
        }
    }
}
