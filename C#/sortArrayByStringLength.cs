using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
  public static string[] SortByLength (string[] array)
  {
    return array
           .OrderBy(x => x.Length)
           .ToArray();
  }
}