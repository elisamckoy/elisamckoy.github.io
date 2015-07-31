/************************* This File is set to not compile so is not part of the working solution *****************************/
using System;
using System.Collections.Generic;

namespace NumbersInRange
{
    public class Program
    {
        public static void Main()
        {
            // The Driver Code is provided for this challenge.
            Console.WriteLine(CountBetween(new List<int> {1, 2, 3}, 0, 10));
            Console.WriteLine(CountBetween(new List<int> {-10, 1, 2}, 0, 10));
            Console.WriteLine(CountBetween(new List<int> {10, 20, 30}, 10, 30));
            Console.WriteLine(CountBetween(new List<int>(), -100, 100));
            Console.WriteLine(CountBetween(new List<int> {0}, 0, 0));

            // These lines are to stop the program from finishing execution. This allows you to see the result of your Driver Code.
            Console.WriteLine("Click [Enter] to exit");
            Console.ReadLine();
        }

        public static int CountBetween(List<int> numbers, int lowerBound, int upperBound)
        {
            var numbersInRange = new List<int>();
            foreach (var number in numbers)
            {
                if (lowerBound <= number && number <= upperBound)
                    numbersInRange.Add(number);
            }
            return numbersInRange.Count;
        }
    }
}