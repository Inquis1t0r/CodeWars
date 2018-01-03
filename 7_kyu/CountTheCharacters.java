public class CC {
  public static int charCount(String str, char c) {
    int count = 0;
  
    for (int i = 0; i < str.length(); i++) {
      if (Character.toLowerCase(str.charAt(i)) == c) {
          count++;
    }
}
  return count;
  }

}
