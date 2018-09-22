public class BumpsTheRoad {
  public static String bumps(final String road) {
    int bumpCounter = 0;
    char[] roadArray = road.toCharArray();
    
    for (char letter: roadArray) {
      if (letter == 'n')
        bumpCounter++;
    }
    
    if (bumpCounter > 15)
      return "Car Dead";
    return "Woohoo!";
  }
}