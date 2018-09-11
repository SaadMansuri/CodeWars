using System;

public class Kata
{
  public static string GetMiddle(string s)
  {
    var middlePoint = s.Length / 2;
    var middle = s[middlePoint].ToString();
  
    if (s.Length % 2 == 0)
        middle = middle.Insert(0, s[middlePoint - 1].ToString());

    return middle;  
      
  }
}