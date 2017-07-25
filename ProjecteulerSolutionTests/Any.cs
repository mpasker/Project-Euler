using System;

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
    }
}
