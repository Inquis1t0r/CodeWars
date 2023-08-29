using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
        bool isPetals1Even = flower1 % 2 == 0;
        bool isPetals2Even = flower2 % 2 == 0;

        //return flower1 % 2 != flower2 % 2 ;
        //return (flower1 + flower2) % 2 == 1;
        //return Convert.ToBoolean((flower1 ^ flower2) & 1);
        return (isPetals1Even && !isPetals2Even) || (!isPetals1Even && isPetals2Even);
    }
}
