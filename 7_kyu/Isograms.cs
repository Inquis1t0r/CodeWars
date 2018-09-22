using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    // Code on you crazy diamond!        
    char[] arr = str.ToLower().ToCharArray();

    return (arr.Length != arr.Distinct().Count()) ? false : true;

  }
}
