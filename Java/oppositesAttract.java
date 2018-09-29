public class OppositesAttract {

  public static boolean isLove(final int flower1, final int flower2) {

      int numberOfEvenAndOddPetals = 0;
      
      if (flower1 % 2 == 0) {
        numberOfEvenAndOddPetals++;
      }
      
      if (flower2 % 2 == 0) {
        numberOfEvenAndOddPetals++;
      }
      
      return (numberOfEvenAndOddPetals == 1);

  }
  
}