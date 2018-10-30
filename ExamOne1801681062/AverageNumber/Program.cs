using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers:");
            bool isZero = false;
            List<int> evenNumbers = new List<int>();

            while (!isZero)
            {
               
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber == 0) break;

                if (currentNumber % 2 == 0)
                {
                    evenNumbers.Add(currentNumber);

                }
            }
                if (evenNumbers.Count > 0)
                {
                    Console.WriteLine($"Total even numbers:{evenNumbers.Count} => Average={evenNumbers.Average()}");
                }
                else
                {
                    Console.WriteLine("There are no even numbers....!");
                }

            
        }
    }
}
