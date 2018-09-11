using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        // REFACTORED CODE
        
        var vowels = new List<char>{'a', 'e', 'i', 'o', 'u'};
        
        return str.Count(c => vowels.Contains(c));
        
        // OLD CODE

//         int vowelCount = 0;

//         // Your code here
//         foreach (var letter in str)
//         {
//           if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
//           {
//             vowelCount++;
//           }
//         }

//         return vowelCount;
    }
}


/* The total number of vowels is {0}", str1.ToLower().Count(c=> vowels.Contains(c))); */