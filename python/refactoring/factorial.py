class FactorialCalculator:
    def calculate(self, n: int) -> int:
        if n == 0:
            return 1
        else:
            return n * self.calculate(n - 1)