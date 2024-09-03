using System;

namespace Kata
{
    public class FibonacciCalculator
    {
        public int Calculate(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
