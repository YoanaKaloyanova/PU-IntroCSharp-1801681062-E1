using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(100, 1000);
            Console.WriteLine($"The first random side of the Rectangle is: {a}");
            int b = rnd.Next(100, 1000);
            Console.WriteLine($"The second random side of the Rectangle is:{b}");
            double S = a * b;
            double x = Math.Round(S,2);
            Console.WriteLine($"The rectangular area is: {x}");
        }
    }
}
