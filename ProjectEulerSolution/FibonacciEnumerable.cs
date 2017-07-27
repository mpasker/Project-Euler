using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class FibonacciEnumerable
    {
        internal IEnumerable<int> GetEnumerable()
        {
            var first = 1;
            var second = 1;

            while (true)
            {
                var sum = first + second;
                first = second;
                second = sum;
                yield return sum;
            }
        }
    }
}
