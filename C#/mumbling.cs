using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
    var repeater = 1;
    var newStr = "";

    for (var i = 0; i < s.Length; i++)
    {
      for (var j = 0; j < repeater; j++)
      {
        if (j == 0)
          newStr += Char.ToUpper(s[i]);            
        else
          newStr += Char.ToLower(s[i]);
      }
     
      repeater++;
       
      if (i != s.Length - 1)
        newStr += "-";
     }
     
     return newStr;
  }
}