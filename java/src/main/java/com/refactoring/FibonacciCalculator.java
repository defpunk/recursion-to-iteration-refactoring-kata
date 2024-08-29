package com.refactoring;

public class FibonacciCalculator {

    public int calculate(int input) {
        if(input < 2){
            return input;
        }
        return calculate(input -1) + calculate(input - 2);
    }

}