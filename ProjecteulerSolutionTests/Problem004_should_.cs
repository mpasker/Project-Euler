using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEulerSolution;

namespace ProjectEulerSolutionTests
{
    class Problem004_should_
    {
        [Test]
        public void get_the_product_of_two_numbers()
        {
            var instance = new Problem004();
            var firstFactor = Any.Number(100, 999);
            var secondFactor = Any.Number(100, 999);
            var expectedProduct = firstFactor * secondFactor;

            var actualProduct = instance.GetProduct(firstFactor, secondFactor);

            Assert.AreEqual(expectedProduct, actualProduct);

        }

        [Test]
        public void determine_if_number_is_a_palindrome()
        {
            var instance = new Problem004();
            var palindromicNumber = Any.PalindromicNumber();

            var isPalindrome = instance.IsPalindrome(palindromicNumber);

            Assert.IsTrue(isPalindrome);
        }

        [Test]
        public void determine_if_number_is_not_a_palindrome()
        {
            var instance = new Problem004();
            var nonPalindromicNumber = Any.PalindromicNumber() + 1;

            var isPalindrome = instance.IsPalindrome(nonPalindromicNumber);

            Assert.IsFalse(isPalindrome);
        }

        [Test]
        public void find_the_largest_palindromic_product_of_two_two_digit_numbers()
        {
            var instance = new Problem004();
            var largestPalindrome = instance.GetLargestPalindromicProductWithFactorsOfNDigits(2);

            Assert.AreEqual(9009, largestPalindrome);
        }

        [Test]
        public void find_the_largest_palindromic_product_of_two_three_digit_numbers()
        {
            var instance = new Problem004();
            var largestPalindrome = instance.GetLargestPalindromicProductWithFactorsOfNDigits(3);

            Assert.AreEqual(9009, largestPalindrome);
        }
    }
}
