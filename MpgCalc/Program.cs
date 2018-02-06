using System;

namespace MpgCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven;
            double gasConsumed;
            double mpg;

            Console.WriteLine("We will calculate your MPG");
            Console.WriteLine("How many miles have you driven?");
            milesDriven = double.Parse(Console.ReadLine());
            Console.WriteLine("How much gas have you used (in gallons)?");
            gasConsumed = double.Parse(Console.ReadLine());

            mpg = milesDriven / gasConsumed;

            Console.WriteLine("You're currently gettting " + mpg + " miles-per-gallon.");
            Console.ReadLine();
        }
    }
}
