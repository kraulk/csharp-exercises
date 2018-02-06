using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double width;
            double height;

            Console.WriteLine("We will calculate the area of a rectangle.");
            Console.WriteLine("What is the width of the rectangle?");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the rectangle?");
            height = double.Parse(Console.ReadLine());

            area = width * height;

            Console.WriteLine("The area of the triangle is: " + area);
            Console.ReadLine();
        }
    }
}
