public class GhostCode{
  public static String helloName(final String name){
  // there was Carriage return unicode in the comment
  
    if(name == null || name.equals(""))
      return "Hello world!";
    else
      return "Hello my name is " + name;
  }
}
