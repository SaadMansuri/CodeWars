public class Sequence{

  public static int[] reverse(int n){
    
    int[] values = new int[n];
    int counter = n;
    
    for (int i = 0; i < n; i++) {
        values[i] = counter;
        counter--;
    }
    
    return values;
  }
}