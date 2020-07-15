using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      //long[] longs = n.ToString().Select(long.Parse).ToArray();
      int[] result = n.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
      long[] longs = result.Select(item => (long)item).ToArray();
      Array.Reverse(longs);
      return longs;
    }
  }
}
