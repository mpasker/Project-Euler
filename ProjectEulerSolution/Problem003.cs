using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class Problem003
    {
        internal long RunningQuotient;

        internal int GetLargestPrimeDivisor(long quotient)
        {
            RunningQuotient = quotient;
            var divisor = 2;
            while (RunningQuotient > divisor)
            {
                while (!IsDivisibleBy(RunningQuotient, divisor))
                {
                    divisor++;
                }

                FindQuotientofDividend(divisor);
            }
            return divisor;
        }

        internal void FindQuotientofDividend(int divisor)
        {
            RunningQuotient /= divisor;
        }

        internal bool IsDivisibleBy(long dividend, int divisor)
        {
            return dividend % divisor == 0;
        }

    }
}
