public class Kata {
  public static String longestWord(String wordString) {
    
    String[] words = wordString.split(" ");
    int longestWordCounter = words[0].length();
    String longestWord = words[0];
    
    for (int i = 1; i < words.length; i++) {
      if (words[i].length() >= longestWordCounter) {
        longestWordCounter = words[i].length();
        longestWord = words[i];
      } 
    }
    return longestWord;
  }
}