import System.Linq;

public class Kata
{
  public static int SumTriangularNumbers(int n)
  {
  
  
    //TODO - finish
   
    int[] arr = new int[n];
    
    for(int i = 0; i < n; i++)
    {
      arr[i] = ((i*(i + 1))/2);
    }
    
   int result = arr.Sum();
    
    return result;
  }
}
