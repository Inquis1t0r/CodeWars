public class Kata
{
  public static bool Check(object[] a, object x)
  {
    
    int test = 0;
    
    foreach(object sth in a)
    {
      if(sth.Equals(x))
      test += 1;
    }
    
    return test == 0 ? false : true;
  }
}
