using System;

public class Kata
{
  public static bool IsAscOrder(int[] arr)
  {
      for (var i = 0; i < arr.Length - 1; i++)
      {
        if (arr[i] > arr[i + 1])
          return false;
      }
      return true;
  }
}