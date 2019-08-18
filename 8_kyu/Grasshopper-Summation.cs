using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int result = 0;
      for(int i = num; i > 0; i--)
      result += i;
      
      return result;
    }
}
