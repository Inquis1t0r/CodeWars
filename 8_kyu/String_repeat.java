public class Solution {
    public static String repeatStr(final int repeat, final String string) {
    
    StringBuilder myStringBuilder = new StringBuilder();

        for(int i = repeat; i > 0; i--)
        myStringBuilder.append(string);
        
        return myStringBuilder.toString();
    }
}
