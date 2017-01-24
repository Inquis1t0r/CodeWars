public class RepeatIt {

  public static String repeatString(final Object toRepeat, final int n) {
  StringBuilder myString = new StringBuilder();
  
  if (toRepeat.getClass().equals(String.class))
  {
  
      for( int i = n ; i > 0 ; i--)
      {
      myString.append(toRepeat);
      }
      
      return myString.toString(); 
  }
      else
      return "Not a string";
  }
  
}
