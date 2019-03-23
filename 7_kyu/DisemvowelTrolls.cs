using System;

public static class Kata
{
  public static string Disemvowel(string str)
  {
      //Works flawlessly on Visual Studio 2017 and dotnetfiddle.net, but can't pass Kata tests for some reason 
      //TODO: Find reason
      
      char[] vowels  = new char[]{'A','a','E','e','I','i','O','o','U','u'};
		
		  foreach (var c in vowels)
      {
            str = str.Replace(c.ToString(), '');
      }
       
    return str;
  }
}
