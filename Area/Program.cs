using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double radius;
            double area;

            Console.WriteLine("Enter a radius: ");
            radius = double.Parse(Console.ReadLine());

            area = pi * radius * radius;

            Console.WriteLine($"The area of circle with radius {radius} is: {area}.", radius, area);
            Console.ReadLine();
        }
    }
}
