public class WrongEndHead {
  public static String[] fixTheMeerkat(String[] arr) {
    String[] reversed = new String[arr.length];
    int counter = 0;
    
    for (int i = arr.length - 1; i >= 0; i--) {
      reversed[counter] = arr[i];
      counter++;
    }
    
    return reversed;
  }
}