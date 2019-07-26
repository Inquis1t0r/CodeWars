using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        int result = 0;
        var groups = seq.GroupBy(z => z);
        
        foreach(var group in groups)
        {
          if(group.Count() % 2 != 0)
          result = group.Key;
        }  
        
        return result;
      }
       
    }
}
