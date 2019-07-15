using System;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        { 
            int sumAtClerk = 0;
            int check = 0;
            
            for (int i = 0; i < peopleInLine.Length; i++)
              {
                sumAtClerk += 25;
                
                if(peopleInLine[i] - 25 <= sumAtClerk)
                check += 1;

              }
        return  check == peopleInLine.Length ? "YES" : "NO";
        }
}
