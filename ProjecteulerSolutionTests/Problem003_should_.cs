using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    class Problem003_should_
    {
        [Test]
        public void check_if_number_is_divisible_by_another_number()
        {
            var instance = new Problem003();
            var divisor = Any.Number();
            var dividend = Any.Number() * divisor;

            var isDivisible = instance.IsDivisibleBy(dividend, divisor);

            Assert.IsTrue(isDivisible);
        }

        [Test]
        public void check_if_number_is_not_divisible_by_another_number()
        {
            var instance = new Problem003();
            var divisor = Any.NumberDivisibleByTwo();
            var dividend = Any.NumberDivisibleByTwo() * divisor + 1;

            var isDivisible = instance.IsDivisibleBy(dividend, divisor);

            Assert.IsFalse(isDivisible);
        }

        [Test]
        public void return_quotient_of_two_numbers()
        {
            var instance = new Problem003();
            var divisor = Any.Number();
            var dividend = Any.Number() * divisor;
            instance.RunningQuotient = dividend;
            var expectedQuotient = dividend / divisor;

            instance.FindQuotientofDividend(divisor);

            Assert.AreEqual(expectedQuotient, instance.RunningQuotient);
        }

        [Test]
        public void output_largest_prime_divisor()
        {
            var instance = new Problem003();
            var startingQuotient = 30;
            var result = instance.GetLargestPrimeDivisor(startingQuotient);
            
            Assert.AreEqual(5, result);
        }

        [Test]
        public void find_largest_prime_factor_of_600851475143()
        {
            var instance = new Problem003();
            var startingQuotient = 600851475143;
            var result = instance.GetLargestPrimeDivisor(startingQuotient);

            Assert.AreEqual(6857, result);
        }
    }
}
