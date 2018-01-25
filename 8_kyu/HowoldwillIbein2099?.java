public class AgeDiff 
{
  public String CalculateAge(int birth, int yearTo) 
  {
    String result="";
    
    if(birth == yearTo)
    result = "You were born this very year!";
    
    if((birth < yearTo) && ((birth - yearTo) != 1))
    result = "You are " + (Math.abs(birth - yearTo))  + " years old.";
    
    if((birth < yearTo) && (Math.abs(birth - yearTo) == 1))
    result = "You are 1 year old.";
    
    if(birth > yearTo && (Math.abs(birth - yearTo) != 1))
    result = "You will be born in " + (Math.abs(yearTo - birth)) + " years.";
    
    if(birth > yearTo && (Math.abs(birth - yearTo) == 1))
    result = "You will be born in 1 year.";
    
    return result;
  }
}
