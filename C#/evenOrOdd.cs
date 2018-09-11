using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
//       if (number % 2 == 0)
//         return "Even";
//       return "Odd";

        
        // REFACTORED TO ONE LINE
        
        return number % 2 == 0 ? "Even" : "Odd";
      
    }
  }
}