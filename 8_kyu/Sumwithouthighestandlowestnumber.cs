using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    int sum = 0;
    
    if(numbers == null || numbers.Length == 0)
    sum = 0;
    else 
    {
      Array.Sort(numbers);
      numbers[0] = 0;
      numbers[numbers.Length - 1] = 0;
      
      foreach (int number in numbers)
      {
          sum += number;
      }   
    }
    return sum;
  }
}
