using System;

public class Kata
{
  public static string ZebulansNightmare(string functionName)
  {
                String result = "";
            for (int i = 0; i < functionName.Length; i++)
            {
                if (functionName[i].Equals('-') || functionName[i].Equals('_'))
                {

                    result += Char.ToUpper(functionName[i + 1]);
                    i++;
                }
                else
                    result += functionName[i];
            }
            return result;
  }
}
