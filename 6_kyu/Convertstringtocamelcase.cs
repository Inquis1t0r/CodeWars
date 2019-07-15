using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
        String result = "";
        for (int i = 0; i < str.Length; i++)
        {
        if(str[i].Equals('-') || str[i].Equals('_'))
          {
            result += "";
            //Char.ToUpper(c)
            result += Char.ToUpper(str[i + 1]);
            i++;
          }
        else
        result += str[i];
        }
    return result;
  }
}
