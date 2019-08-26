using System;
using System.Text;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    StringBuilder sb = new StringBuilder("");
    
    foreach (char c in str)
    {
       if(Char.IsUpper(c))
       sb.Append(" "+ c.ToString());
       else 
       sb.Append(c.ToString());
    }
    return sb.ToString();
  }
}
