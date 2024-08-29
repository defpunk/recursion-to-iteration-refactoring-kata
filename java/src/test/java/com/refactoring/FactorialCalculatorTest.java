package com.refactoring;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class FactorialCalculatorTest {

    private FactorialCalculator calculator;

    @BeforeEach
    void setup(){
        calculator = new FactorialCalculator();
    }

    @Test
    void calculateShouldReturn_1_when_input_1(){
        int result = calculator.calculate(1);
        assertEquals(1, result);
    }

    @Test
    void calculateShouldReturn_2_when_input_2(){
        int result = calculator.calculate(2);
        assertEquals(2, result);
    }

    @Test
    void calculateShouldReturn_6_when_input_3(){
        int result = calculator.calculate(3);
        assertEquals(6, result);
    }

    @Test
    void calculateShouldReturn_24_when_input_4(){
        int result = calculator.calculate(4);
        assertEquals(24, result);
    }

    @Test
    void calculateShouldReturn_120_when_input_5(){
        int result = calculator.calculate(5);
        assertEquals(120, result);
    }

    @Test
    void calculateShouldReturn_720_when_input_6(){
        int result = calculator.calculate(6);
        assertEquals(720, result);
    }

    @Test
    void calculateShouldReturn_5040_when_input_7(){
        int result = calculator.calculate(7);
        assertEquals(5040, result);
    }


    @Test
    void calculateShouldReturn_40320_when_input_8(){
        int result = calculator.calculate(8);
        assertEquals(40320, result);
    }

}
