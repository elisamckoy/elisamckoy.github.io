using System;
using System.Collections.Generic;
using System.Reflection;

namespace REPLTestSupport
{
    internal class HelperMethods
    {
        /*********** REFLECTION METHODS *************/

        public static bool hasMethod(Type classType, String methodName)
        {
            return classType.GetMethod(methodName) != null;
        }

        public static MethodInfo getMethod(Type classType, String methodName)
        {
            return classType.GetMethod(methodName);
        }

        public static ParameterInfo[] getMethodParameters(Type classType, String methodName)
        {
            return getMethod(classType, methodName).GetParameters();
        }

        public static FieldInfo getField(Object subject, Type classType, String fieldName)
        {
            var fi = classType.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            return fi;
        }

        public static FieldInfo getField(Type classType, String fieldName)
        {
            var fi = classType.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            return fi;
        }

        /*
        public static ArrayList getPublicInstanceMethods(Object subject)
        {
          return subject.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);
        }
        */

        public static FieldInfo[] getPublicFields(Object subject)
        {
            return subject.GetType().GetFields();
        }

        public static FieldInfo[] getAllFields(Object subject)
        {
            return subject.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        }

        /************** RANDOM METHODS *************/

        public static double getRandom(double min, double max)
        {
            var random = new Random();
            return min + (random.NextDouble()*(max - min));
        }

        public static int getRandom(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        public static List<int> randomiseList(List<int> list)
        {
            var randomisedList = new List<int>();
            var random = new Random();
            while (list.Count != 0)
            {
                var i = random.Next(0, list.Count);
                randomisedList.Add(list[i]);
                list.RemoveAt(i);
            }
            return randomisedList;
        }

        public static List<String> randomiseList(List<String> list)
        {
            var randomisedList = new List<String>();
            var random = new Random();
            while (list.Count != 0)
            {
                var i = random.Next(0, list.Count);
                randomisedList.Add(list[i]);
                list.RemoveAt(i);
            }
            return randomisedList;
        }
    }
}