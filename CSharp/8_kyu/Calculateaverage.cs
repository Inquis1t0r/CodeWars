using System.Linq;

class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    // Your code here
    return array.Length > 0 ? array.Sum()/array.Length : 0;
  }
} 
