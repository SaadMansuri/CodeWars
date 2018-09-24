public class Kata{
  public static String bonusTime(final int salary, final boolean bonus) {

//     StringBuilder money = new StringBuilder("£");    
//     if (bonus) {
//       return (money.append(salary * 10)).toString();
//       }
//       return money.append(salary).toString();

        if (bonus)
          return "£" + (salary * 10);
          
        return "£" + salary;
  }
}