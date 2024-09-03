using Xunit;

namespace Kata.Tests
{
    public class FactorialCalculatorTests
    {
        [Fact]
        public void Test_calculate_returns_1_when_input_1()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(1, factorialCalculator.Calculate(1));
        }

        [Fact]
        public void Test_calculate_returns_2_when_input_2()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(2, factorialCalculator.Calculate(2));
        }

        [Fact]
        public void Test_calculate_returns_6_when_input_3()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(6, factorialCalculator.Calculate(3));
        }

        [Fact]
        public void Test_calculate_returns_24_when_input_4()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(24, factorialCalculator.Calculate(4));
        }

        [Fact]
        public void Test_calculate_returns_120_when_input_5()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(120, factorialCalculator.Calculate(5));
        }

        [Fact]
        public void Test_calculate_returns_720_when_input_6()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(720, factorialCalculator.Calculate(6));
        }

        [Fact]
        public void Test_calculate_returns_5040_when_input_7()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(5040, factorialCalculator.Calculate(7));
        }

        [Fact]
        public void Test_calculate_returns_40320_when_input_8()
        {
            var factorialCalculator = new FactorialCalculator();
            Assert.Equal(40320, factorialCalculator.Calculate(8));
        }
    }
}
