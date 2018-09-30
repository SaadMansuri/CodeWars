public class GrassHopper {

    public static int summation(int n) {

      int sumOfEveryNumberBetween1AndNum = 0;
      
      while (n > 0) {
        sumOfEveryNumberBetween1AndNum += n;
        n--;
      }

        return sumOfEveryNumberBetween1AndNum;
    }
}