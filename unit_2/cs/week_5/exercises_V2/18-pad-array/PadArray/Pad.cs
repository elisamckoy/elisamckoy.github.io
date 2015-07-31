/******************************************************
Exercise: Create a method to pad a List<object> 

In C# everything is an object and a List must have a declared type to denote the type of the items inside it. 
By stipulating that it should be of type object we are effectively saying it con be anything.
eg string, int, array, float, a List<int> (yes you can have a list inside a list) etc...

Write two methods, PadOriginal and PadNew which take as their input an List<object>, a length to pad up to, and an object for padding.
PadNew should return a different List and the original should be untouched.
PadOriginal should modify the original List.
*******************************************************/

using System;
using System.Collections.Generic;

namespace PadArray
{
    public class Pad
    {
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
