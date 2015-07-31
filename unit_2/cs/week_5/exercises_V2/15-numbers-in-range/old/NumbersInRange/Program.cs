/******************** Summary *************************
Exercise: Count the numbers in an array between a given range 
 
Write a method CountBetween which takes three arguments as input: A List of Integers, An integer lower bound, An integer upper bound
  
CountBetween should return the number of integers in the List between the two bounds, including the bounds. It should return 0 if the ArrayList is empty.

Remember to run the tests to see if your code works.
*******************************************************/

using System;
using System.Collections.Generic;

namespace NumbersInRange
{
    public class Program
    {
        public static void Main()
        {
            // The Driver Code is provided for this challenge.
            Console.WriteLine(CountBetween(new List<int>(){1,2,3}, 0, 10));
            Console.WriteLine(CountBetween(new List<int>(){-10,1,2}, 0, 10));
            Console.WriteLine(CountBetween(new List<int>(){10,20,30}, 10, 30));
            Console.WriteLine(CountBetween(new List<int>(){}, -100, 100));
            Console.WriteLine(CountBetween(new List<int>(){0}, 0, 0));

            // These lines are to stop the program from finishing execution. This allows you to see the result of your Driver Code.
            Console.WriteLine("Click [Enter] to exit");
            Console.ReadLine();
        }

        public static int CountBetween(List<int> numbers, int lowerBound, int upperBound)
        {
            // Your code here - remove the NotImplementedException
            throw new NotImplementedException();
        }
    }
}