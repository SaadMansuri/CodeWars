public class Positive{

  public static int sum(int[] arr){
    
    int sumOfPositives = 0;
    
    for (int number: arr) {
      if (number > 0) {
        sumOfPositives += number;
      }
    }
    
    return sumOfPositives;
    
  }