public class Kata{

  public static int grow(int[] x){

    int v = 1;
    
    for (int number: x) {
      v *= number;
    }

    return v;
  }
}