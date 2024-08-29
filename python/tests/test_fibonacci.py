import unittest

from refactoring.fibonacci import FibonacciCalculator

class TestFibonacci(unittest.TestCase):

    def test_calculate_returns_0_when_input_0(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(0), 0)

    def test_calculate_returns_1_when_input_1(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(1), 1)

    def test_calculate_returns_1_when_input_2(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(2), 1)

    def test_calculate_returns_2_when_input_3(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(3), 2)

    def test_calculate_returns_3_when_input_4(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(4), 3)

    def test_calculate_returns_5_when_input_5(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(5), 5)

    def test_calculate_returns_8_when_input_6(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(6), 8)

    def test_calculate_returns_13_when_input_7(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(7), 13)

    def test_calculate_returns_21_when_input_8(self):
        fibonacci_calculator = FibonacciCalculator()
        self.assertEqual(fibonacci_calculator.calculate(8), 21)

if __name__ == "__main__":
    unittest.main()
