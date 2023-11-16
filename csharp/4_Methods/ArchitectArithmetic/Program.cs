using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateTotalCost();
            Console.ReadLine();
        }

        static void CalculateTotalCost()
        {
            // For testing.
            // Console.WriteLine(Rectangle(4, 5));
            // Console.WriteLine(Circle(4));
            // Console.WriteLine(Triangle(10, 9));

            // Calculating the area of Teotihuacan.
            double rectangle = Rectangle(2500, 1500);
            double halfCircle = Circle(187.5) / 2;
            double triangle = Triangle(750, 500);
            double areaOfTeotihuacan = rectangle + halfCircle + triangle;
            // Console.WriteLine($"The area of Teotihuacan in square meters: {areaOfTeotihuacan}");

            // Calculating total flooring costs
            double costOfFlooring = Math.Round(180 * areaOfTeotihuacan, 2);
            Console.WriteLine($"The cost of flooring material needed for Teotihuacan: {costOfFlooring}");
        }

        static double Rectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}
