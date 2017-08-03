using NUnit.Framework;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    public class Problem002_should_
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

        [Test]
        public void return_sum_of_even_numbers()
        {
            var instance = new Problem002();
            var number = Any.NumberDivisibleByTwo();

            instance.AddToSumIfDivisibleByTwo(number);

            Assert.AreEqual(number, instance.RunningTotal);
        }
        
        [Test]
        public void find_the_sum_of_even_fibonacci_numbers_less_than_ten()
        {
            var instance = new Problem002();

            var sum = instance.GetSumOfEvenFibonacciNumbers(10);

            Assert.AreEqual(10, sum);
        }

        [Test]
        public void find_the_sum_of_even_fibonacci_numbers_less_than_four_million()
        {
            var instance = new Problem002();

            var sum = instance.GetSumOfEvenFibonacciNumbers(4000000);

            Assert.AreEqual(4613732, sum);
        }
    }
}
