using System;

public static class Kata
{

    public static string greet() 
    {
      string mystery = "01101000 01100101 01101100 01101100 01101111 00100000 01110111 01101111 01110010 01101100 01100100 00100001";
      return Convert.ToBase64String(Encoding.ASCII.GetBytes(mystery));
    }
}
