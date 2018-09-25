public class Kata {
  public static int rentalCarCost(int d) {

    int discount = 0;
    int baseCost = d * 40;
    
    if (d >= 3 && d < 7)
      discount = 20;
    else if (d >= 7) 
      discount = 50;
    
    return baseCost - discount;
  }
}