/******************** Summary *************************
Exercise: Create a method to pad a List<int>
Write two methods, PadOriginal and PadNew which takes as their input an List<int>, a length to pad up to, and an object for padding.
PadNew should return a different List<int> and the original should be untouched.abstract
PadOriginal should modify the original List<int>.
*******************************************************/

using System;
using System.Collections.Generic;

namespace PadArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Put your driver code here.


            // These lines are to stop the program from finishing execution. This allows you to see the result of your Driver Code.
            Console.WriteLine("Click [Enter] to exit");
            Console.ReadLine();
        }

        public List<object> PadOriginal(List<object> array, int minSize, Object padding = null)
        {
            // Your code here - remove the NotImplementedException
            throw new NotImplementedException();
        }

        public List<object> PadNew(List<object> array, int minSize, Object value = null)
        {
            // Your code here - remove the NotImplementedException
            throw new NotImplementedException();
        }
    }
}