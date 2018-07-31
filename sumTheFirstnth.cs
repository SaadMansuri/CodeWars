using System;

public class NthSeries {
  
  public static string seriesSum (int n) {
    // Happy Coding ^_^
    if (n == 0)
    {
      return "0.00";
    }
    
    decimal sum = 1;
    decimal denominator = 4;
    
    while (n > 1)
    {
      sum += (1/denominator);
      n--;
      denominator += 3;
    }
    
    return $"{sum:f2}";
  }
}