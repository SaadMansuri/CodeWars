public class XO {
  
  public static boolean getXO (String str) {
    
    char[] strArray = str.toCharArray();
    int xCounter = 0;
    int oCounter = 0;
    
    for (char letter : strArray) {
    
      if (letter == 'x' || letter == 'X')
        xCounter++;
      else if (letter == 'o' || letter == 'O') 
        oCounter++;
      }
      
      return xCounter == oCounter;
  }
}