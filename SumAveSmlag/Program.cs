using System;

namespace SumAveSmlag
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double average = (a + b + c) / 3;
            double smallest = (a + b + c) / 3;
            double largest = (a + b + c) / 3;
            Console.WriteLine("1,923.53");
            Console.WriteLine("1923,53");
            Console.WriteLine("1,924");
            Console.WriteLine("{0:F5}", average);
            Console.WriteLine("{0}", smallest);
            Console.WriteLine("{0}", largest);

        }
    }
}
