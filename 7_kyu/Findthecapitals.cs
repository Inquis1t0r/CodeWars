using System;
using System.Linq;

public static class Kata
{
  public static int[] Capitals(string word)
  {
		//Write your code here
    //finish!
    var capitalLetters = word.Where(c => char.IsUpper(c)).ToArray();
    int[] result = new int[capitalLetters.Length];
    for (int i = 0; i < capitalLetters.Length; i++)
      {
          result[i] =capitalLetters[i].ParseInt32();
      }
    
    return result;
  }
}
