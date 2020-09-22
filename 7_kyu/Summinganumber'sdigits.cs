using System;
using System.Linq;

public class Kata
{
  public static int SumDigits(int number)
  {
    int[] digits = number.ToString().Replace("-", "").Select(c => Convert.ToInt32(c.ToString())).ToArray();
    return digits.Sum();
  }
}
