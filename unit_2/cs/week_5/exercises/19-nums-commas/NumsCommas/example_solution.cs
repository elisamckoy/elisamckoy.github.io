/************************* This File is set to not compile so is not part of the working solution *****************************/
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


// Solution 2: using Regular Expression aka regex
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
