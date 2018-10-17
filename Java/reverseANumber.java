public class ReverseNumber {

	public static int reverse(int number) {
    
    String numberString = new StringBuilder(Integer.toString(number)).reverse().toString();
    StringBuilder finalStr = new StringBuilder();
    
    if (numberString.contains("-")) {
      finalStr.append("-");
      finalStr.append(numberString.replace("-", ""));
    }
    else {
      finalStr.append(numberString);
    }
    
    return Integer.parseInt(finalStr.toString());
	}
}
