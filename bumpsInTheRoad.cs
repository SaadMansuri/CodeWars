using System;
using System.Linq;

class Kata
{
    public static string Bump(string input)
    {
        var bumps = input.Count(c => "n".Contains(c));
        
        if (bumps <= 15)
          return "Woohoo!";
        return "Car Dead";
    }
}