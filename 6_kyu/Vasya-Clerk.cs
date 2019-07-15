using System;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        { 
            int sumAtClerk = 0;
            Boolean check = false;
            
            for (int i = 0; i < peopleInLine.Length; i++)
              {
                sumAtClerk += 25;
                
                if(peopleInLine[i] - 25 <= sumAtClerk)
                check = true;
                else
                check = false;
              }
        return  check != false ? "YES" : "NO";
        }
    }
