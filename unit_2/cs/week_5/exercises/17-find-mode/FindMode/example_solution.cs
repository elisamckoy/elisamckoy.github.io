/************************* This File is set to not compile so is not part of the working solution *****************************/
using System;
using System.Collections.Generic;

namespace FindMode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ignore this for this challenge
        }

        public List<int> Mode(List<int> array)
        {
            var frequencies = new Dictionary<int, int>();
            var modes = new List<int>();

            foreach (var number in array)
            {
                if (frequencies[number] == null)
                    frequencies[number] = 1;
                else
                    frequencies[number] = frequencies[number] + 1;
            }

            var values = new List<int>(frequencies.Values);
            values.Sort();
            var maxFrequency = values[values.Count - 1];

            foreach (var entry in frequencies)
            {
                if (entry.Value == maxFrequency)
                    modes.Add(entry.Key);
            }

            return modes;
        }
    }
}