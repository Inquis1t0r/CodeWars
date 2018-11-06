using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    // test fails (?)
    
    char[] numCharArray = num.ToString().ToCharArray();
    int output = 0;
    Array.Reverse(numCharArray);
    
    for (int i = 0; i < numCharArray.Length; i++)
      {
          output += Convert.ToInt32(numCharArray[i]);
      }
    
    string result = string.Join("", numCharArray);
    return Convert.ToInt32(result);
  }
}
