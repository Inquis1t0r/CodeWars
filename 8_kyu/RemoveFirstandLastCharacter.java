public class RemoveChars {
    public static String remove(String str) {
    
    String solution = str.replaceAll("^.|.$", "");
    return solution;
    }
}

