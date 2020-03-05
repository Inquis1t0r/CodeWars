using System;
using static System.Math;  

public class Kata
{

  public static int GetLastDigit(int index)
  {
    int number = index - 1; 
    int[] Fib = new int[number + 1];  
    Fib[0]= 0;  
    Fib[1]= 1;  
    for (int i = 2; i <= number;i++)  
    {  
       Fib[i] = Fib[i - 2] + Fib[i - 1];  
    }  
    return Math.Abs(Fib[number] % 10);  
  }
}
