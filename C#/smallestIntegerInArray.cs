// Finding smallest integer in an array 3 different ways

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        var smallestIntegerInArray = args[0];
        
        for (var i = 1; i < args.Length; i++)
        {
          if (args[i] < smallestIntegerInArray)
          {
            smallestIntegerInArray = args[i];
          }
        }
        return smallestIntegerInArray;
    }
}



using System;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        Array.Sort(args);
        
        return args[0];
    }
}



using System;
using System.Linq;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        return args.Min();
    }
}