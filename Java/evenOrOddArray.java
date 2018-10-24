public class Codewars {
  public static String oddOrEven (int[] array) {
    
    int sumOfArray = 0;
  
    for (int num : array) {
      sumOfArray += num;
    }
  
    return sumOfArray % 2 == 0 ? "even" : "odd";
  }
}