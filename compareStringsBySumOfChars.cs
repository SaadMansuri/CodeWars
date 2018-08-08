using System;
using System.Linq;

public static class Kata
{
  public static bool Compare(string s1, string s2)
  { 
       var s1Sum = 0;
       var s2Sum = 0;
      
       if (String.IsNullOrEmpty(s1))
       {
         s1Sum = 0;
       }
       else
       {
         foreach (var letter in s1)
         {
           if (!Char.IsLetter(letter))
           {
               s1Sum = 0;
               break;  
           }
  
           s1Sum += Char.ToUpper(letter);
         }
       }
       
       if (String.IsNullOrEmpty(s2))
       {
         s2Sum = 0;
       }
       else
       {      
        foreach (var letter in s2)
         {
           if (!Char.IsLetter(letter) || String.IsNullOrEmpty(s2))
           {
               s1Sum = 0;
               break;  
           }
           
           s2Sum += Char.ToUpper(letter);
         }
       }
       
       if (s1Sum == s2Sum)
         return true;
         
        return false;    
  }
}