using System;
using System.Linq;

public class Kata
{
  public static int SumDigits(int number) => number.ToString().Replace("-", "").Select(c => Convert.ToInt32(c.ToString())).ToArray().Sum();
}
