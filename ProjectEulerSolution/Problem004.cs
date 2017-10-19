using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class Problem004
    {
        public int GetLargestPalindromicProductWithFactorsOfNDigits(int numberOfDigits)
        {
            var upperLimit = (int)(Math.Pow(10, numberOfDigits) - 1);
            int highestProduct = 0;
            for (var i = upperLimit; i > 0; i--)
            {
                for (var j = upperLimit; j >= i; j--)
                {
                    var product = GetProduct(i, j);
                    if (IsPalindrome(product) && product > highestProduct)
                    {
                        highestProduct = product;
                    }
                }
            }

            return highestProduct;
        }
        public int GetProduct(int firstFactor, int secondFactor)
        {
            return firstFactor * secondFactor;
        }

        public bool IsPalindrome(int number)
        {
            var numberToString = number.ToString();
            var numberToStringReversed = string.Join(string.Empty, numberToString.Reverse());

            return numberToString.Equals(numberToStringReversed);

        }

    }
}
