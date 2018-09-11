using System;

public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
  {    
        // REFACTORED CODE
        
        DateTime current = DateTime.Parse(currentDate);
        DateTime expiration = DateTime.Parse(expirationDate);

        return current <= expiration && enteredCode == correctCode;
        
        
        // ORIGINAL CODE
        
        // bool isValid;

        // if (enteredCode != correctCode)
        //     return false;            
        // else
        //     isValid = true;
            
        // DateTime current = DateTime.Parse(currentDate);
        // DateTime expiration = DateTime.Parse(expirationDate);

        // if (DateTime.Compare(current, expiration) <= 0)
        //     isValid = true;
        // else
        //     isValid = false;

        // return isValid;
  }
}