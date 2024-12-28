public class Solution {
    public static String doubleChar(String s) {
        String result = new String();
        //enter your code here 
        for (char tempChar: s.toCharArray()) {
            System.out.println(tempChar);
            String character = String.valueOf(tempChar);
            result += character + character;
        }
        return result;
    }
}
