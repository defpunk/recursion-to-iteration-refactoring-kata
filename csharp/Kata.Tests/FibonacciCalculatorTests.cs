using Xunit;

namespace Kata.Tests
{
    public class FibonacciCalculatorTests
    {
        [Fact]
        public void Test_calculate_returns_0_when_input_0()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(0, fibonacciCalculator.Calculate(0));
        }

        [Fact]
        public void Test_calculate_returns_1_when_input_1()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(1, fibonacciCalculator.Calculate(1));
        }

        [Fact]
        public void Test_calculate_returns_1_when_input_2()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(1, fibonacciCalculator.Calculate(2));
        }

        [Fact]
        public void Test_calculate_returns_2_when_input_3()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(2, fibonacciCalculator.Calculate(3));
        }

        [Fact]
        public void Test_calculate_returns_3_when_input_4()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(3, fibonacciCalculator.Calculate(4));
        }

        [Fact]
        public void Test_calculate_returns_5_when_input_5()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(5, fibonacciCalculator.Calculate(5));
        }

        [Fact]
        public void Test_calculate_returns_8_when_input_6()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(8, fibonacciCalculator.Calculate(6));
        }

        [Fact]
        public void Test_calculate_returns_13_when_input_7()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(13, fibonacciCalculator.Calculate(7));
        }

        [Fact]
        public void Test_calculate_returns_21_when_input_8()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            Assert.Equal(21, fibonacciCalculator.Calculate(8));
        }

    }

}