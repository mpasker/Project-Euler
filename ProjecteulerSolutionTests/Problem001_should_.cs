using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Problem001_should_
    {
        [Test]
        public void determine_if_number_is_divisible_by_three()
        {
            var instance = new Problem001();
            var number = Any.NumberDivisibleByThree();

            var divisibleResult = instance.IsNumberDivisibleByThree(number);

            Assert.IsTrue(divisibleResult);
        }

        [Test]
        public void determine_if_number_is_not_divisible_by_three()
        {
            var instance = new Problem001();
            var number = Any.NumberDivisibleByThree() + 1;

            var divisibleResult = instance.IsNumberDivisibleByThree(number);

            Assert.IsFalse(divisibleResult);
        }

        [Test]
        public void determine_if_number_is_divisible_by_five()
        {
            var instance = new Problem001();
            var number = Any.NumberDivisibleByFive();

            var divisibleResult = instance.IsNumberDivisbleByFive(number);

            Assert.IsTrue(divisibleResult);
        }

        [Test]
        public void determine_if_number_is_not_divisible_by_five()
        {
            var instance = new Problem001();
            var number = Any.NumberDivisibleByFive() + 1;

            var divisibleResult = instance.IsNumberDivisbleByFive(number);

            Assert.IsFalse(divisibleResult);
        }

        [Test]
        public void add_total_of_numbers_divisible_by_three()
        {
            var instance = new Problem001();
            var number = Any.NumberDivisibleByThree();
            
            instance.AddToSumIfDivisibleByThreeOrFive(number);

            Assert.AreEqual(number, instance.RunningTotal);
        }

        [Test]
        public void add_total_of_numbers_divisible_by_five()
        {
            var instance = new Problem001();
            var number = Any.NumberDivisibleByFive();

            instance.AddToSumIfDivisibleByThreeOrFive(number);

            Assert.AreEqual(number, instance.RunningTotal);
        }

        [Test]
        public void find_the_sum_of_multiples_of_three_and_five_in_a_range()
        {
            var instance = new Problem001();

            var sumOfNumbers = instance.GetSumOfNumbersDivisibleByThreeAndFive(1, 999);

            Assert.AreEqual(233168, sumOfNumbers);
        }
    }
}