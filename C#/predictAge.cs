using System;
using System.Collections.Generic;

public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8){
            var ageArray = new int[]{ age1, age2, age3,age4, age5, age6, age7, age8 };
            var sumOfAllMultiples = 0;

            foreach (var age in ageArray)
                sumOfAllMultiples += age * age;
            
            return (int)Math.Sqrt(sumOfAllMultiples) / 2;
    }
}