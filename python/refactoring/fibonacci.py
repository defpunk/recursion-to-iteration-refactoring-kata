class FibonacciCalculator:
    def calculate(self, n: int) -> int:
        if n < 2:
            return n
        return self.calculate(n - 1) + self.calculate(n - 2)