public class Kata {
    public static String reverseLetter(final String str) {
    
        char[] strArray = str.toCharArray();
        StringBuilder reversedStr = new StringBuilder();
        
        for (char letter : strArray) {
          if (Character.isLetter(letter)) {
            reversedStr.append(letter);
          }
        }
    
        return reversedStr.reverse().toString();
    }
}