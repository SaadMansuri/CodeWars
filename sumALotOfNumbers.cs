public class Kata
{
  public static long? RangeSum(long n)
  {
//     Note: This function's runtime can be made to be near-instant, but it should not be necessary for this Kata.
  
//     Insert your code here... and go crazy!
//     long sum = 0;
    
//     if (n <= 0)
//     {
//       return null;
//     }
    
//     while (n > 0)
//     {
//       sum += n;
//       n--;
//     }
    
//     return sum;

//   OR

    if (n < 1)
      return null;
      
    return (n) * (n + 1) / 2;

  }
  
  }