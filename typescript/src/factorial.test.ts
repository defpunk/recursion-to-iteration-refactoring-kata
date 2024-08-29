import factorial from "./factorial";

describe('factorial', () => {
    it('should return 1 when input is 1', () => {
        expect(factorial(1)).toBe(1);
    });
    it('should return 2 when input is 2', () => {
        expect(factorial(2)).toBe(2);
    });
    it('should return 6 when input is 3', () => {
        expect(factorial(3)).toBe(6);
    });
    it('should return 24 when input is 4', () => {
        expect(factorial(4)).toBe(24);
    });
    it('should return 120 when input is 5', () => {
        expect(factorial(5)).toBe(120);
    });
    it('should return 720 when input is 6', () => {
        expect(factorial(6)).toBe(720);
    });
    it('should return 5040 when input is 7', () => {
        expect(factorial(7)).toBe(5040);
    });
    it('should return 40,320 when input is 8', () => {
        expect(factorial(8)).toBe(40320);
    });
});