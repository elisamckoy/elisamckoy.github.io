/********************************* This File is not compiled or tested ********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateCreditCard
{
    public class CreditCard
    {
        long number;

        public CreditCard(long num)
        {
            if (num.ToString().Length == 16)
            {
                number = num;
            }
            else
            {
                throw new ArgumentException("Cannot create card with the wrong number length!");
            }
        }

        public bool CheckCard()
        {
            List<long> luhnNumbers = new List<long>();
            long total = 0;

            for (int i = 0; i < 16; i++)
            {
                long digit = number;
                if (i % 2 != 0)
                {
                    if (digit * 2 < 9)
                    {
                        luhnNumbers.Add(digit * 2);
                    }
                    else
                    {
                        long sum = 0;
                        long n = digit;

                        while (n != 0)
                        {
                            sum += n % 10;
                            n /= 10;
                        }
                        luhnNumbers.Add(sum);
                    }

                }
                else
                {
                    luhnNumbers.Add(digit);
                }
                total += luhnNumbers[i];
            }
            if (luhnNumbers[15] % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
