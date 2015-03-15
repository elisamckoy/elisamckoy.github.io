/********************************* This File is not compiled or tested ********************************/
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

        public List<object> PadOriginal(List<object> array, int minSize, Object padding = null)
        {
            int spacesToAdd = minSize - array.Count;
            if (padding == null)
                padding = 0;

            for (int index = 0; index < spacesToAdd; index++)
            {
                array.Add(padding);
            }
            return array;
        }

        public List<object> PadNew(List<object> array, int minSize, Object padding = null)
        {
            int spacesToAdd = minSize - array.Count;
            if (padding == null)
                padding = 0;

            List<object> newArray = (List<object>)array.Clone();
            for (int index = 0; index < spacesToAdd; index++)
            {
                newArray.Add(padding);
            }
            return newArray;
        }

    }
}