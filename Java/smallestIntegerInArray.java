public class SmallestIntegerFinder {
    public static int findSmallestInt(int[] args) {

      int smallestIntegerInArray = args[0];
      
      for (int i = 1; i < args.length; i++) {s
          if (args[i] < smallestIntegerInArray) {
            smallestIntegerInArray = args[i];
          }
      }
      return smallestIntegerInArray;
    }
}



import java.util.Arrays; 

public class SmallestIntegerFinder {
    public static int findSmallestInt(int[] args) {

      Arrays.sort(args);
      return args[0];
    }
}