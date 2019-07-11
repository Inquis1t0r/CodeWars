using System;

public class Kata 
{
  public static double Arithmetic(double a, double b, string op) 
  {
    //throw new NotImplementedException();
    double result = 0;
    
    switch (op) { 
              
        case "add": 
            result = a + b; 
            break; 
  
        case "subtract": 
            result = a - b;
            break; 
            
        case "multiply": 
            result = a * b;
            break; 
            
        case "divide": 
            result = a/b;
            break; 
        } 
    
    return result;
  }
}
