using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class Problem005
    {
        public bool NumberIsEvenlyDivisible(int numberOne, int numberTwo)
        {
            return numberOne % numberTwo == 0;
        }

        public int GetLeastCommonMultipleOfRange(int min, int max)
        {
            var lcm = 1;
            for (var i = min; i <= max; i++)
            {
                var multiple = 1;
                while (!NumberIsEvenlyDivisible(lcm * multiple, i))
                {
                    multiple++;
                }
                lcm *= multiple;
            }
            return lcm;
        }
    }
}