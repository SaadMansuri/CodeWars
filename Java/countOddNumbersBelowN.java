public class Kata {

  public static int oddCount(int n){

    int positiveOddNumbersCount = 0;

    while (n > 0) {
      if (n % 2 == 0) {
        positiveOddNumbersCount++;
      }
      n--;
    }

    return positiveOddNumbersCount;
  }

}