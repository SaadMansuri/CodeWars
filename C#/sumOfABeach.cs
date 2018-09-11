public class Kata
{
    public static int SumOfABeach(string s)
    {
        // your code
        var lowerS = s.ToLower();
        int sum = 0;
        
        sum += Counter(lowerS, "sand");
        sum += Counter(lowerS, "water");
        sum += Counter(lowerS, "fish");
        sum += Counter(lowerS, "sun");
        
        return sum;
    }
    
    public static int Counter(string text, string pattern)
    {
      int count = 0;
      int i = 0;
      while ((i = text.IndexOf(pattern, i)) != -1)
      {
          i += pattern.Length;
          count++;
      }
    
      return count;
    }
    
}


// OR

using System.Text.RegularExpressions;

public class Kata
{
    public static int SumOfABeach(string s)
    {
        // your code
        return Regex.Matches(s.ToLower(), "sand|water|fish|sun").Count;
    }
}