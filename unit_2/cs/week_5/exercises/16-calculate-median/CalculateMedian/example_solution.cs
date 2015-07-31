/************************* This File is set to not compile so is not part of the working solution *****************************/
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace PadArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public static float Median(List<int> list)
        {
            list.Sort();
            if (list.Count % 2 == 0)
            {
                var sum = list[(list.Count / 2) - 1] + list[list.Count / 2];
                return sum / (float)2.0;
            }
            var temp = list[list.Count / 2];
            return temp;
        }
    }
}