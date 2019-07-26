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
        
        foreach(var group in seq.GroupBy(z => z))
        {
          if(group.Count() % 2 != 0)
          result = group.Key;
        }  
        
        return result;
      }
       
    }
}
