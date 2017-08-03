using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    internal class Problem002
    {
        internal int RunningTotal;

        internal int GetSumOfEvenFibonacciNumbers(int endingNumber)
        {
            var enumerator = new FibonacciEnumerable().GetEnumerable().GetEnumerator();
            var number = enumerator.Current;

            while (number < endingNumber)
            {
                AddToSumIfDivisibleByTwo(number);
                enumerator.MoveNext();
                number = enumerator.Current;
            }

            enumerator.Dispose();
            return RunningTotal;
        }

        internal void AddToSumIfDivisibleByTwo(int number)
        {
            if (!IsEven(number))
                return;
            RunningTotal += number;
        }

        internal bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }   
}
