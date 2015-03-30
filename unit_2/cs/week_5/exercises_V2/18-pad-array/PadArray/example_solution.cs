using System;
using System.Collections.Generic;

namespace PadArray
{
    public class Pad
    {
        public List<object> PadOriginal(List<object> list, int minSize, Object padding = null)
        {
            int spacesToAdd = minSize - list.Count;
            if (padding == null)
            {
                padding = 0;
            }

            for (int index = 0; index < spacesToAdd; index++)
            {
                list.Add(padding);
            }
            return list;
        }

        public List<object> PadNew(List<object> list, int minSize, Object padding = null)
        {
            List<object> newArray = new List<object>();
            int spacesToAdd = minSize - list.Count;
            if (padding == null)
            {
                padding = 0;
            }

            foreach (var item in list)
            {
                newArray.Add(item);
            }

            for (int index = 0; index < spacesToAdd; index++)
            {
                newArray.Add(padding);
            }
            return newArray;
        }
    }
}
