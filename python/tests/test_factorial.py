import unittest

from refactoring.factorial import FactorialCalculator

class TestFactorial(unittest.TestCase):
    
    def test_calculate_returns_1_when_input_1(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(1), 1)

    def test_calculate_returns_2_when_input_2(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(2), 2)

    def test_calculate_returns_6_when_input_3(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(3), 6)

    def test_calculate_returns_24_when_input_4(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(4), 24)

    def test_calculate_returns_120_when_input_5(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(5), 120)

    def test_calculate_returns_720_when_input_6(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(6), 720)

    def test_calculate_returns_5040_when_input_7(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(7), 5040)

    def test_calculate_returns_40320_when_input_8(self):
        factorial_calculator = FactorialCalculator()
        self.assertEqual(factorial_calculator.calculate(8), 40320)

if __name__ == "__main__":
    unittest.main()