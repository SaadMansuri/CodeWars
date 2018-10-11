public class Repeater{
  public static String repeat(String string,long n){
  
    StringBuilder repeatedString = new StringBuilder();
    
    for (int i = 0; i < n; i++) {
      repeatedString.append(string);
    }
  
    return repeatedString.toString();
  
  }
}