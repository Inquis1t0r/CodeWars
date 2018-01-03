public class DecTools {
  public static int Digits(long n) {
//TODO: integer underflow/overflow  check/prevention !
    String s = Integer.toString(Math.toIntExact(n)); 

    return s.length();
  }
}
