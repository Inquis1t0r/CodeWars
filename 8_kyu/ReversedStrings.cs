using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    //throw new NotImplementedException("TODO: Kata.Solution(string) => string");
    char[] charArray = str.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
  }
}
