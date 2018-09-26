import org.apache.commons.lang3.StringUtils;

public class Kata
{
  public static String reverseWords(final String original)
  {
    
    if (original.length() == 0 || StringUtils.isBlank(original)) {
        return original;
    }

    // create empty string builder to store reversed strings
    StringBuilder reversedString = new StringBuilder();
    // split original string into an array to loop through
    String[] stringsArray = original.split(" ");
    
    for (int i = 0; i < stringsArray.length; i++) {
        // reverse each word of the array
        StringBuilder singleReversedString = new StringBuilder(stringsArray[i]).reverse(); 
        // append the reversed word to the string builder and add space
        reversedString.append(singleReversedString).append(" ");
    }
    
    // trimming whitespace on string
    return reversedString.toString().trim();
    
  }
}