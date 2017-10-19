using System;
using System.Linq;
using NUnit.Framework;

namespace ProjectEulerSolutionTests
{
    public static class Any
    {
        private static Random Random { get; }

        static Any()
        {
            Random = new Random();
        }

        public static int NumberDivisibleByTwo()
        {
            return Random.Next(1, 100) * 2;
        }

        public static int NumberDivisibleByThree()
        {
            return Random.Next(1, 100) * 3; 
        }

        public static int NumberDivisibleByFive()
        {
            return Random.Next(1, 100) * 5;
        }

        public static int Number(int min = 1, int max = 100)
        {
            return Random.Next(min, max);
        }

        public static int PalindromicNumber()
        {
            var randomNumber = Number();
            var numberToString = randomNumber.ToString();
            var numberToStringReversed = string.Join(string.Empty, numberToString
                .Reverse().Select(x => x.ToString()));
            var palindromicString = numberToString + numberToStringReversed;
            var palindromicNumber = int.Parse(palindromicString);

            return palindromicNumber;

        }
    }
}
