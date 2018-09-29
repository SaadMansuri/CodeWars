public class Kata {

  public static boolean isDivisible(int wallLength, int pixelSize) {

//         if (wallLength % pixelSize == 0) {
//           return true;
//         }
//         return false;

//       boolean isDiv = (wallLength % pixelSize == 0);
//       return isDiv;

        return wallLength % pixelSize == 0;
  }

}