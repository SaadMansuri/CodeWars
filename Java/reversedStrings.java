import java.lang.*; 
import java.io.*; 
import java.util.*;

public class Kata {

  public static String solution(String str) {
    // Your code here...
    StringBuilder s = new StringBuilder();
    s = s.append(str);
    return s.reverse().toString();
  }
}