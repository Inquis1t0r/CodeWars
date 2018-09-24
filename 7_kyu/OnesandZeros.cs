using System;
using System.Text;

namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          //TODO!
          //Code here
          string binaryString = string.Join(",", BinaryArray);
         // var text = Encoding.ASCII.GetBytes(binaryString).ToInt32;
         int x = Int32.Parse(binaryString);
         //  int i = ToInt32(binaryString);
        //   string result = Convert.ToString(i,10);
         return  Convert.ToString(Convert.ToInt32(x, 2));
        }
    }
}
