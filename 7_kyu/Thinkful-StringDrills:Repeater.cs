using System.Text;

public class Kata
{
  public static string Repeater(string s, int n)
  {
    //Your code goes here.
    StringBuilder sb = new StringBuilder();
   

    while(n != 0)
    {
       sb.Append(s);
       n--;
    }
    
    return sb.ToString();
  }

}
