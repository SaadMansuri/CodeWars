public class Kata {

  public static boolean feast(String beast, String dish) {
    
    char[] beastArr = beast.toCharArray();
    char[] dishArr = dish.toCharArray();
    
    return 
    (beastArr[0] == dishArr[0]) && (beastArr[beast.length() - 1] == dishArr[dish.length() - 1]);
    
  }
  
}
  