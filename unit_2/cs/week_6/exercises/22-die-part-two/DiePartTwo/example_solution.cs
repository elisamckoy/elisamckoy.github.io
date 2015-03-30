/********************************* This File is not compiled or tested ********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiePartTwo
{
    public class Die
    {
        List<String> sides;

        public Die(List<String> labels)
        {
            if (labels.Count < 1)
                throw new ArgumentException("Number of sides must be greater than one", "sides");
            else
                sides = labels;
        }

        public int Sides()
        {
            return sides.Count;
        }

        public String Roll()
        {
            var random = new Random();
            int roll = random.Next(0, sides.Count);
            return sides[roll];
        }
    }
}
