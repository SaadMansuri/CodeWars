using System;
using System.Collections.Generic;

public class FizzBuzz
{
	public static string[] GetFizzBuzzArray(int n)
	{
        if (n <= 0)
            throw new ArgumentOutOfRangeException();
  
        var fizzBuzzArr = new string[n];
    
        for (int i = 1, j = 0; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                fizzBuzzArr[j] = "FizzBuzz";
            else if (i % 3 == 0)
                fizzBuzzArr[j] = "Fizz";
            else if (i % 5 == 0)
                fizzBuzzArr[j] = "Buzz";
            else
                fizzBuzzArr[j] = i.ToString();
            j++;
        }
    
        return fizzBuzzArr;
	}
}