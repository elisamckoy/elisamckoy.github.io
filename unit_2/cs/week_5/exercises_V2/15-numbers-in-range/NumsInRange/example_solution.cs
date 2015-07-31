using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsInRange
{
    public class Nums
    {
        public int CountBetween(List<int> numbers, int lowerBound, int upperBound)
        {
            var numbersInRange = new List<int>();
            foreach (var number in numbers)
            {
                if (lowerBound <= number && number <= upperBound)
                    numbersInRange.Add(number);
            }
            return numbersInRange.Count;
        }
    }
}
