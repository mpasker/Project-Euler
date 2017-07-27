using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    class Problem002_should_
    {
        [Test]
        public void determine_if_number_is_even()
        {
            var instance = new Problem002();
            var number = Any.NumberDivisibleByTwo();

            var isNumberEven = instance.IsEven(number);

            Assert.IsTrue(isNumberEven);
        }

        [Test]
        public void determine_if_number_is_not_even()
        {
            var instance = new Problem002();
            var number = Any.NumberDivisibleByTwo() + 1;

            var isNumberEven = instance.IsEven(number);

            Assert.IsFalse(isNumberEven);
        }
    }
}
