public class SequenceSum{

  public static String showSequence(int value){
    //for
    //  while
    int sum = 0; 
    
    for (int i = 0; i <= value; i++) { 
      sum = sum + i;    
    } 
    
    return String.valueOf(sum);
  }

  /*public static void main(String args[]){
    int param=Integer.ParseInt(args[0]);
    SequenceSum.showSequence(param);
  }*/
}
