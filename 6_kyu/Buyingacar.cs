using System;

public class BuyCar {

	public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth) {

    int months = 0;
    int savingsTotal = 0;
    
    while(savingsTotal + startPriceOld < startPriceNew)
    {
      months ++;
      if (months % 2 == 0) {
        percentLossByMonth += 0.5; 
      }
    }
    
    savingsTotal += savingPerMonth;
    
    startPriceOld -= startPriceOld * (int)(percentLossByMonth / 100);
    startPriceNew -= startPriceNew * (int)(percentLossByMonth / 100);
    
    int result = Convert.ToInt16(Math.Round((double)savingsTotal + startPriceOld - startPriceNew));
    
    int[] array = new int[2] {months, result};
    
		return array;
	}
}
