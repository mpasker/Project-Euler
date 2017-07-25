namespace ProjectEulerSolution
{
    public class Problem001
    {
        internal int RunningTotal;

        internal int GetSumOfNumbersDivisibleByThreeAndFive(int startingNumber, int endingNumber)
        {
            for (var i = startingNumber; i <= endingNumber; i++)
            {
               AddToSumIfDivisibleByThreeOrFive(i);    
            }
            
            return RunningTotal;
        }

        internal void AddToSumIfDivisibleByThreeOrFive(int numberToTest)
        {
            if (IsNumberDivisibleByThree(numberToTest) || IsNumberDivisbleByFive(numberToTest))
            {
                RunningTotal += numberToTest;
            }
        }

        internal bool IsNumberDivisibleByThree(int numberToTest)
        {
            return numberToTest % 3 == 0;
        }

        internal bool IsNumberDivisbleByFive(int numberToTest)
        {
            return numberToTest % 5 == 0;
        }
    }
}