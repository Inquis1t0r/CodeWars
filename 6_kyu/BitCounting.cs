using System;

public class Kata
{
  public static int CountBits(int n)
  {
    var binary = Convert.ToString(n, 2);
    
    int result = 0; 
    foreach(char c in binary)
    {
         if(c == '1')
        result++;
    }
  
    Console.WriteLine(binary);
    return result;
  }
}
