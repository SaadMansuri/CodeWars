public class Solution {
    public static String repeatStr(final int repeat, final String string) {

      StringBuilder repeatedString = new StringBuilder();
      
      for (int i = 0; i < repeat; i++) {
        repeatedString.append(string);
      }
      
      return repeatedString.toString();
    }
}