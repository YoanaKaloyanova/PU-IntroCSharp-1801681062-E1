using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you wanna calculate some numbers?(yes or no)");
            string answer = Console.ReadLine();
            while (answer != "yes")
            { Console.WriteLine("Do you wanna calculate some numbers?(yes or no)"); }
            
                
            Console.WriteLine("Enter the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the code corresponding to the name of the desired operation:");
            Console.WriteLine("1: +");
            Console.WriteLine("2: -");
            Console.WriteLine("3: *");
            Console.WriteLine("4: /");
            Console.WriteLine("-------------------------------------------");
            int option = int.Parse(Console.ReadLine());
            switch (option)

            {
                case 1:
                    double x = a + b;
                    double y=x*0.10;
                    double z = x + y;
                    double u = Math.Round(z, 2);
                    Console.WriteLine($"The result is: {u}");
                    break;
                case 2:
                    if (a > b)
                    {
                        double A = a * a;
                        Console.WriteLine($"The bigger number powered on 2 is: {A}");
                        double B = A - b;
                        double r = Math.Round(B, 2);
                        Console.WriteLine($"The result it: {r}");
                    }
                    else
                    {
                        double A = b * b;
                        Console.WriteLine($"The bigger number powered on 2 is: {A}");
                        double B = A - a;
                        double d = Math.Round(B, 2);
                        Console.WriteLine($"The result it: {d}");
                    }
                    break;
                case 3:
                    double sqrtNumber = Math.Sqrt(b);
                    double Q = a * sqrtNumber;
                    double o = Math.Round(Q, 2);
                    Console.WriteLine($"The result it: {o}");
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Error! We cant divide by 0!");
                        break;
                    }
                    else
                    {
                        double W = a / b;
                        double s = Math.Round(W, 2);
                        Console.WriteLine($"The result is: {s}");
                    }
                    break;
                default: Console.WriteLine("Error operation");break;
                    Console.WriteLine("Do you wanna calculate some numbers?(yes or no)");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "no")
                        break;
            }
    }
}
