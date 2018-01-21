public class Bob {
  public static int enough(int cap, int on, int wait){
  int sumOfPassengers = on + wait;
  
  return (sumOfPassengers > cap) ? Math.abs(sumOfPassengers - cap) : 0; 
  
  
  }
}
