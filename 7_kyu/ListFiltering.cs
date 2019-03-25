using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
   var numbers = new List<int>();
        
   
   foreach(var item in listOfItems)
   if(item is int)
     {
       numbers.Add((int)item);
     }  
     
     return numbers;
   }
}
