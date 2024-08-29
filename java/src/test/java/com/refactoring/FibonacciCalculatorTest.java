package com.refactoring;
import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class FibonacciCalculatorTest {

    private FibonacciCalculator calculator;

    @BeforeEach
    void setup(){
        calculator = new FibonacciCalculator();
    }

    @Test
    void calculateShouldReturn_0_when_input_0(){
        int result = calculator.calculate(0);
        assertEquals(0, result);
    }

    @Test
    void calculateShouldReturn_1_when_input_1(){
        int result = calculator.calculate(1);
        assertEquals(1, result);
    }

    @Test
    void calculateShouldReturn_1_when_input_2(){
        int result = calculator.calculate(2);
        assertEquals(1, result);
    }

    @Test
    void calculateShouldReturn_2_when_input_3(){
        int result = calculator.calculate(3);
        assertEquals(2, result);
    }

    @Test
    void calculateShouldReturn_3_when_input_4(){
        int result = calculator.calculate(4);
        assertEquals(3, result);
    }

    @Test
    void calculateShouldReturn_5_when_input_5(){
        int result = calculator.calculate(5);
        assertEquals(5, result);
    }

    @Test
    void calculateShouldReturn_8_when_input_6(){
        int result = calculator.calculate(6);
        assertEquals(8, result);
    }

    @Test
    void calculateShouldReturn_13_when_input_7(){
        int result = calculator.calculate(7);
        assertEquals(13, result);
    }

    @Test
    void calculateShouldReturn_21_when_input_8(){
        int result = calculator.calculate(8);
        assertEquals(21, result);
    }

}
