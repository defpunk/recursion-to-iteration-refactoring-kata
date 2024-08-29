package com.refactoring;

public class FactorialCalculator {
    
    public int calculate(int input) {
        if(input == 1){
            return 1;
        }
        return input * calculate(input -1);
    }

}
