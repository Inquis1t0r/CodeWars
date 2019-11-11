using System;
using System.Globalization;

public class Kata
{
  public static string NumberFormat(int number)
  {
    return number.ToString("#,##0", new CultureInfo("en-US"));
  }
}
