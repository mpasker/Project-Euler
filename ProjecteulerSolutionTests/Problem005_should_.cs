using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    class Problem005_should_
    {
        [Test]
        public void check_if_number_is_evenly_divisible_by_another_number()
        {
            var instance = new Problem005();
            var number = Any.Number();

            var result = instance.NumberIsEvenlyDivisible(2 * number, number);

            Assert.IsTrue(result);
        }

        [Test]
        public void find_the_least_common_multiple_of_one_through_ten()
        {
            var instance = new Problem005();
            var multiple = instance.GetLeastCommonMultipleOfRange(1, 10);

            Assert.AreEqual(2520, multiple);
        }

        [Test]
        public void find_the_least_common_multiple_of_one_through_twenty()
        {
            var instance = new Problem005();
            var multiple = instance.GetLeastCommonMultipleOfRange(1, 20);

            Assert.AreEqual(232792560, multiple);
        }
    }
}
