/********************************* This File is not compiled or tested ********************************/
// Solution 1: using string methods and if statements
using System;
using System.Collections.Generic;

namespace NumsCommas
{
    class Program
    {
        private static void Main(string[] args)
        {
        }

         public static String SeparateComma(int number)
        {
            var toReturn = "";

            // the number is turned into a string and then reversed which returns a collection of characters (char),
            // this needs the .ToArray() as otherwise the reverse method doesn't know what collection to give back.
            var asString = number.ToString().Reverse().ToArray();
            for (var i = 0; i < asString.Length; i++)
            {
                if (i == 0 || i%3 != 0)
                {
                    toReturn = asString[i] + toReturn;
                }
                else
                {
                    toReturn = asString[i] + "," + toReturn;
                }
            }
            return toReturn;
        }
    }
}


//Solution 2: is part of the {0:n0} string.format method. check out the documentation for it. its a helper method for turning numbers into strings in the pattern we want.
//note the first 0 is a ref to the number variable passed in after the comma. the colon accesses options, the n denotes that the we only want numbers and the 0 is the number of decimal places

using System;
using System.Collections.Generic;

namespace NumsCommas
{
    class Program
    {
        private static void Main(string[] args)
        {
        }

        public String SeparateComma(int number)
        {
            return String.Format("{0:n0}", number);
        }
    }
}
