using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    class FibonacciEnumerable_should_
    {
        [Test]
        public void return_numbers_of_fibonacci_sequence()
        {
            var expectedValue = new List<int> {2, 3, 5, 8, 13};
            var instance = new FibonacciEnumerable();
            var enumerator = instance.GetEnumerable();

            var actualValue = enumerator.Take(5).ToList();

            CollectionAssert.AreEqual(expectedValue, actualValue);
        }
    }
}
