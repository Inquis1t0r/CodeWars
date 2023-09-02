using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
  //Code goes here!
  var index = Array.FindIndex(haystack, stackItem => stackItem == "needle");
  return ("found the needle at position " + index);
  }
}
