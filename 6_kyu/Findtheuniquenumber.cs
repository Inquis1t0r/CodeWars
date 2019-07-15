using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
        var dict = new Dictionary<int, int>();
        int result = 0;
        foreach (var number in numbers)
    		{
    		if (dict.ContainsKey(number))
            dict[number]++;
        else
            dict[number] = 1;
    		}
        
        foreach(var pair in dict)
        {
        if(pair.Value == 1)
        result = pair.Key;
        }
        return result;
  }
}
