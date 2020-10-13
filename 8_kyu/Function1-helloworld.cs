using System;
using System.Text;

public static class Kata
{

    public static string greet() 
    {
      string mystery = "aGVsbG8gd29ybGQh";
      return Encoding.UTF8.GetString(Convert.FromBase64String("mystery"));
    }
}
