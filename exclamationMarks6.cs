using System.Collections.Generic;

public class Kata
{
  public static string Remove(string s, int n)
  {
    //coding and coding....
    List<char> strList = new List<char>(s.ToCharArray());
    while (n > 0)
    {
      strList.Remove('!');
      n--;
    }
    
    return string.Join("", strList.ToArray());
  }
}