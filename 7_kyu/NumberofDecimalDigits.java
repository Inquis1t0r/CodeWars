public class DecTools {
  public static int Digits(long n) {
    int temp = 0;
//TODO: integer underflow/overflow  check/prevention !
    String s = Integer.toString(Math.toIntExact(n)); 

    return s.length();
  }
}
