public class SpinWords {

  public String spinWords(String sentence) {
    
    StringBuilder stringBuilder = new StringBuilder();
    String[] sentenceArray = sentence.split(" ");
    
    for (String word : sentenceArray) {
      
      if (word.length() >= 5) {
//           String reversedWord = reverseWord(word);
          stringBuilder.append(reverseWord(word) + " ");
      }
      else {
          stringBuilder.append(word + " ");
      }
//       stringBuilder.append(" ");
    }
    
    return stringBuilder.toString().trim();
  }
  
  
  public String reverseWord(String word) {
  
    StringBuilder stringBuilder = new StringBuilder(word);
    String reversedWord = stringBuilder.reverse().toString();
    
    return reversedWord;
  }
  
}