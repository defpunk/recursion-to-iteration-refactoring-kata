using System;

namespace Kata
{
    public class FactorialCalculator
    {
        public int Calculate(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * Calculate(number - 1);
        }
    }
}