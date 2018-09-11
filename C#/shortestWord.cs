{
  public static int FindShort(string s)
  {
    var strArr = s.Split(' ');
    var minLength = strArr[0].Length;
    
    foreach(var word in strArr)
    {
      if (word.Length < minLength)
      {
        minLength = word.Length;
      }
    }
    
    return minLength;
    
  }
}