using System;
using System.Linq;

public class Kata
{
  public static int Gimme(double[] inputArray)
  {
  int result = 0;
      foreach(var element in inputArray)
      {
        if(element != inputArray.Max() && element != inputArray.Min())
        {
         result = Array.IndexOf(inputArray, element);
        }
      }
      return result;
  }
}
